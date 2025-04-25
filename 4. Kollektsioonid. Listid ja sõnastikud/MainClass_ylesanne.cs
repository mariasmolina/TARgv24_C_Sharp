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

            Console.WriteLine("--- Ülesanne 1 ---");
            List<Toode> tooted = new List<Toode>();

            tooted.Add(new Toode() { Nimi = "Õun", Kalorid100g = 52 });
            tooted.Add(new Toode() { Nimi = "Banaan", Kalorid100g = 89 });
            tooted.Add(new Toode() { Nimi = "Kartul", Kalorid100g = 77 });
            tooted.Add(new Toode() { Nimi = "Tomat", Kalorid100g = 18 });
            tooted.Add(new Toode() { Nimi = "Kurg", Kalorid100g = 16 });
            tooted.Add(new Toode() { Nimi = "Porgand", Kalorid100g = 41 });
            tooted.Add(new Toode() { Nimi = "Lõhe filee", Kalorid100g = 208 });
            tooted.Add(new Toode() { Nimi = "Kana muna", Kalorid100g = 155 });
            tooted.Add(new Toode() { Nimi = "Kanafilee", Kalorid100g = 165 });
            tooted.Add(new Toode() { Nimi = "Sealiha", Kalorid100g = 242 });
            tooted.Add(new Toode() { Nimi = "Veiseliha", Kalorid100g = 250 });
            tooted.Add(new Toode() { Nimi = "Keedetud riis", Kalorid100g = 130 });


            // Kasutaja andmed
            Console.Write("Sisestage oma nimi: ");
            string nimi = Console.ReadLine();
            Console.Write("Sisestage oma vanus: ");
            int vanus = int.Parse(Console.ReadLine());
            Console.Write("Sisestage sugu (mees/naine): ");
            string sugu = Console.ReadLine();
            Console.Write("Sisestage pikkus (cm): ");
            double pikkus = double.Parse(Console.ReadLine());
            Console.Write("Sisestage kaal (kg): ");
            double kaal = double.Parse(Console.ReadLine());
            Console.Write("-- Aktiivsus tasemed --\n1. Istuv eluviis\n2. Kerge aktiivsus\n3. Mõõdukas aktiivsus\n4. Väga aktiivne\n5. Äärmiselt aktiivne\nValige aktiivsustase (1-5): ");
            double aktiivsus = double.Parse(Console.ReadLine());

            Inimene inimene = new Inimene()
            {
                Nimi = nimi,
                Vanus = vanus,
                Sugu = sugu,
                Pikkus = pikkus,
                Kaal = kaal,
                Aktiivsustase = aktiivsus
            };

            // Päevase energiavajaduse arvutamine Harris-Benedict’i valemi abi
            // https://nutrium.com/blog/harris-benedict-equation-calculator-for-nutrition-professionals/

            double paevaneEnergiavajadus = Math.Round(inimene.ArvutaKalorivajadus(), 2);

            Console.WriteLine($"\n{nimi}, sinu hinnanguline päevane kalorivajadus on {paevaneEnergiavajadus} kcal\n");

            foreach (Toode t in tooted)
            {
                double kogus = Math.Round(paevaneEnergiavajadus / t.Kalorid100g * 100,2);
                Console.WriteLine($"{t.Nimi}: {kogus} g päevas");
            }


            // Ülesanne 2 – Maakonnad ja pealinnad (sõnastik ja test)

            Console.WriteLine("\n--- Ülesanne 2 ---");


        }
    }
}
