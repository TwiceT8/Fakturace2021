using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace fakturace2021
{
    public partial class ZboziForm : Form
    {
        private List<Zbozi> zbozis;
        private int trideni = 0;
        private string[] sloupce = new string[] {"IdZbozi","Nazev","CenaBezDph","NaSklade" };
        private bool sestupne;
        private string filter;
        private SqlRepository sqlRepository;

        public ZboziForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=DESKTOP-MLLJAIA\SQLEXPRESS;Initial Catalog=Fakturace2021;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); 
        }

        public void ZobrazData()
        {
            
            zbozis = sqlRepository.nactiZbozi(sloupce[trideni], sestupne, filter);
            listView1.Items.Clear();
            foreach(var polozka in zbozis)
            {
                listView1.Items.Add(polozka.GetListViewItem());
            }
        }

        private void ZboziForm_Load(object sender, EventArgs e)
        {
            ZobrazData();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == trideni)
            {
                sestupne = !sestupne;
            }
            trideni = e.Column;
            ZobrazData();
        }

        private void txtBoxFiltrZbozi_TextChanged(object sender, EventArgs e)
        {
            filter = txtBoxFiltrZbozi.Text.ToString();
            ZobrazData();
        }

        private void pridatZboziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZboziAddForm zboziAddForm = new ZboziAddForm(new Zbozi("", 0,true));
            if (zboziAddForm.ShowDialog() == DialogResult.OK)
            {
                sqlRepository.ulozZbozi(zboziAddForm.Zbozi);
                
                ZobrazData();
            }
        }

        private void upravitZboziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lv = listView1.SelectedItems[0];
            ZboziAddForm zboziAddForm = new ZboziAddForm(zbozis[listView1.SelectedIndices[0]]);
            if (lv.SubItems[3].Text == true.ToString())
            {
                if (zboziAddForm.ShowDialog() == DialogResult.OK)
                {
                    sqlRepository.ulozZbozi(zboziAddForm.Zbozi);
                    ZobrazData();
                }
                
            }
            else MessageBox.Show("Nelze upravit!");
        }

        private void odebratZboziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lv = listView1.SelectedItems[0];
            ZboziAddForm zboziAddForm = new ZboziAddForm(zbozis[listView1.SelectedIndices[0]]);
            if (lv.SubItems[3].Text == true.ToString())
            {
                var res = MessageBox.Show("Opravdu smazat "+ lv.SubItems[1].Text+"?", "Smazat", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    sqlRepository.smazZbozi(zboziAddForm.Zbozi);
                    ZobrazData();
                }

            }
            else MessageBox.Show("Nelze smazat!");
        }
    }
}
