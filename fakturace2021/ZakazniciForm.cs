using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fakturace2021
{
    public partial class ZakazniciForm : Form
    {
        private List<Zakaznik> zakaznici;
        private SqlRepository sqlRepository;
        private string[] sloupce = new string[] { "IdZakaznici", "Nazev", "TypZakaznika", "Adresa", "Ico","Email","Telefon" };
        private int trideni = 0;
        private bool sestupne;
        private string filtr;
        public ZakazniciForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=DESKTOP-MLLJAIA\SQLEXPRESS;Initial Catalog=Fakturace2021;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        private void ZobrazData()
        {
            zakaznici = sqlRepository.nactiZakazniky(sloupce[trideni], sestupne, filtr);
            listView1.Items.Clear();
            foreach (var zakaznik in zakaznici)
            {
                listView1.Items.Add(zakaznik.GetListViewItem());
            }
        }

        private void ZakazniciForm_Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtr = comboBox1.SelectedItem.ToString();
            if (filtr == "Vše")
                filtr = "";
            ZobrazData();
        }
    }
}
