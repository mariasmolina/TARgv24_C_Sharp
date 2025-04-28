using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp._5._osa___Kollektsioonid._Listid_ja_sõnastikud
{
    internal class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Sugu { get; set; } 
        public double Pikkus { get; set; }
        public double Kaal { get; set; }
        public double Aktiivsustase { get; set; }


        public double ArvutaKalorivajadus()
        {
            double bmr = 0;

            if (Sugu.ToLower() == "mees")
            {
                bmr = 66.5 + (13.75 * Kaal) + (5 * Pikkus) - (6.75 * Vanus);
            }
            else if (Sugu.ToLower() == "naine")
            {
                bmr = 655.1 + (9.563 * Kaal) + (1.85 * Pikkus) - (4.676 * Vanus);
            }

            // Aktiivsuse taseme määramine
            double aktiivsus_tase = 0;

            if (Aktiivsustase == 1)
            {
                aktiivsus_tase = 1.2;
            }
            else if (Aktiivsustase == 2)
            {
                aktiivsus_tase = 1.375;
            }
            else if (Aktiivsustase == 3)
            {
                aktiivsus_tase = 1.55;
            }
            else if (Aktiivsustase == 4)
            {
                aktiivsus_tase = 1.725;
            }
            else if (Aktiivsustase == 5)
            {
                aktiivsus_tase = 1.9;
            }

            double paevaneEnergiavajadus = bmr * aktiivsus_tase;

            return paevaneEnergiavajadus;
        }
    }
}
