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
    public partial class ZboziAddForm : Form
    {
        public Zbozi Zbozi { get; set; }
        public ZboziAddForm(Zbozi zbozi)
        {
            InitializeComponent();
            Zbozi = zbozi;
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            Zbozi.Nazev = txtBoxZboziAdd.Text;
            Zbozi.CenaBezDph = (int)numericZboziAdd.Value;
            Zbozi.NaSklade = true;
            MessageBox.Show(Zbozi.IdZbozi.ToString());
            DialogResult = DialogResult.OK;

        }

        private void ZboziAddForm_Load(object sender, EventArgs e)
        {
            txtBoxZboziAdd.Text = Zbozi.Nazev;
            numericZboziAdd.Value = (decimal)Zbozi.CenaBezDph;
            
        }
    }
}
