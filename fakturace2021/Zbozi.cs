using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fakturace2021
{
    public class Zbozi
    {
        public int IdZbozi { get; set; }
        public string Nazev { get; set; }
        public int CenaBezDph { get; set; }
        public bool NaSklade { get; set; }
        public Zbozi(int idZbozi, string nazev, int cenaBezDph, bool naSklade)
        {
            IdZbozi = idZbozi;
            Nazev = nazev;
            CenaBezDph = cenaBezDph;
            NaSklade = naSklade;
        }

        public ListViewItem GetListViewItem()
        {
            return new ListViewItem(new string[] { IdZbozi.ToString(), Nazev, CenaBezDph.ToString(), NaSklade.ToString() });
        }
    }
}
