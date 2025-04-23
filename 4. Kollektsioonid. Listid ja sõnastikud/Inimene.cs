using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp._4._Kollektsioonid._Listid_ja_sõnastikud
{
    internal class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Sugu { get; set; } 
        public float Pikkus { get; set; }
        public float Kaal { get; set; }
        public int Aktiivsustase { get; set; }  // 1-5

        public Inimene(string nimi, int vanus, string sugu, float pikkus, float kaal, int aktiivsus)
        { 
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
            Pikkus = pikkus;
            Kaal = kaal;
            Aktiivsustase = aktiivsus;
        }
    }
}
