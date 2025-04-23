using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp._3._Failitöötlus
{
    internal class MainClass_ylesanne
    {
        public static void Main(string[] args)
        {
            // 1. Loo failinimi Kuud.txt
            string path =FunktsioonideClass_3osa.FailiPath(@"C:\\Users\\opilane\\Source\\Repos\\TARgv24_C_Sharp\\3. Failitöötlus\\Kuud.txt");

            // 2. Kirjuta programmi abil 3 kuud faili
            FunktsioonideClass_3osa.FailiKirjutamine(path);

            // 3. Loe kuud List<string> sisse
            List<string> kuude_list = FunktsioonideClass_3osa.FailiLugemine(path);

            // 4. Eemalda „Juuni“, muuda esimene element
            FunktsioonideClass_3osa.EemaldamineMuutmine(path, kuude_list);

            // 5. Kuvada kõik kuud
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            // 6. Luba kasutajal otsida kuud nime järgi
            Console.WriteLine("Sisesta kuu nimi, mida otsida:");
            string otsitav_kuu = Console.ReadLine();
            string vastus=FunktsioonideClass_3osa.Otsing(otsitav_kuu, kuude_list);
            Console.WriteLine(vastus);

            // 7. Salvesta muudatused faili tagasi
            FunktsioonideClass_3osa.Salvestamine(path, kuude_list);

        }
    }
}
