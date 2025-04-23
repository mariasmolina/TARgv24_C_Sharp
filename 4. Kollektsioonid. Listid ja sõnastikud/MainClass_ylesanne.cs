using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp._4._Kollektsioonid._Listid_ja_sõnastikud
{
    internal class MainClass_ylesanne
    {
        public static void Main(string[] args)
        {
            // Ülesanne 1 – Kalorite kalkulaator klassidega

            List<Toode> tooded = new List<Toode>();

            tooded.Add(new Toode() { Nimi = "Õun", Kalorid100g = 52 });
            tooded.Add(new Toode() { Nimi = "Banaan", Kalorid100g = 89 });
            tooded.Add(new Toode() { Nimi = "Kartul", Kalorid100g = 77 });
            tooded.Add(new Toode() { Nimi = "Tomat", Kalorid100g = 18 });
            tooded.Add(new Toode() { Nimi = "Kurg", Kalorid100g = 16 });
            tooded.Add(new Toode() { Nimi = "Porgand", Kalorid100g = 41 });
            tooded.Add(new Toode() { Nimi = "Lõhe filee", Kalorid100g = 208 });
            tooded.Add(new Toode() { Nimi = "Kana muna", Kalorid100g = 155 });
            tooded.Add(new Toode() { Nimi = "Kanafilee", Kalorid100g = 165 });
            tooded.Add(new Toode() { Nimi = "Sealiha", Kalorid100g = 242 });
            tooded.Add(new Toode() { Nimi = "Veiseliha", Kalorid100g = 250 });
            tooded.Add(new Toode() { Nimi = "Keedetud riis", Kalorid100g = 130 });



        }
    }
}
