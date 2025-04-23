using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TARgv24_C_Sharp._3._Failitöötlus
{
    internal class FunktsioonideClass_3osa
    {
        public static string FailiPath(string path)
        {
            string faili_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{path}");
            return faili_path;
        }

        public static void FailiKirjutamine(string path)
        {
            try
            {
                using (StreamWriter text = new StreamWriter(path, true))  // Fail suletakse automaatselt siin
                {
                    text.WriteLine("Juuni\nJuuli\nAugust");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
        }

    public static List<string> FailiLugemine(string path)
        {
            List<string> kuude_list = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }

            return kuude_list;
        }

    public static void EemaldamineMuutmine(string path, List<string> kuude_list)
        {
            kuude_list.Remove("Juuni");

            if (kuude_list.Count > 0)
                Console.WriteLine("Sisesta kuu nimi, mida soovide lisada esimesena elemendina:");
                string kuu_vastus = Console.ReadLine();
                kuude_list[0] = kuu_vastus;

            Console.WriteLine("--------------Kustutasime juuni-----------");
        }

    public static string Otsing(string otsitav_kuu, List<string> kuude_list)
        {
            string vastus;
            if (kuude_list.Contains(otsitav_kuu))
                vastus = "Kuu " + otsitav_kuu + " on olemas.";
            else
                vastus = "Sellist kuud pole.";

            return vastus;
        }

    public static void Salvestamine(string path, List<string> kuude_list)
        {
            File.WriteAllLines(path, kuude_list);
            Console.WriteLine("Andmed on salvestatud.");
        }
    }
}
