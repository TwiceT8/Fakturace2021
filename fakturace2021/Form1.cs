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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnZakaznici_Click(object sender, EventArgs e)
        {
            ZakazniciForm zakazniciForm = new ZakazniciForm();
            zakazniciForm.ShowDialog();
        }

        private void btnZbozi_Click(object sender, EventArgs e)
        {
            ZboziForm zboziForm = new ZboziForm();
            zboziForm.ShowDialog();
        }

        private void btnFaktury_Click(object sender, EventArgs e)
        {
            FakturaceForm fakturaceForm = new FakturaceForm();
            fakturaceForm.ShowDialog();
        }
    }
}
