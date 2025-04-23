using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp._4._Kollektsioonid._Listid_ja_sõnastikud
{
    internal class Toode
    {
        public string Nimi { get; set; }
        public int Kalorid100g { get; set; }

        public Toode(string nimi, int kalorid)
        {
            Nimi = nimi;
            Kalorid100g = kalorid;
        }
    }
}
