using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fakturace2021
{
    public class Zakaznik
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public string Typ { get; set; }
        public string Adresa { get; set; }
        public int Ico { get; set; }
        public string Email { get; set; }
        public int telefon { get; set; }
        public Zakaznik(int id, string nazev, string typ, string adresa, int ico, string email, int telefon)
        {
            Id = id;
            Nazev = nazev;
            Typ = typ;
            Adresa = adresa;
            Ico = ico;
            Email = email;
            this.telefon = telefon;
        }

        public Zakaznik()
        {
        }

        public ListViewItem GetListViewItem()
        {
            return new ListViewItem(new string[] { Id.ToString(), Nazev, Typ, Adresa, Ico.ToString(), Email, telefon.ToString() });
        }
    }
}
