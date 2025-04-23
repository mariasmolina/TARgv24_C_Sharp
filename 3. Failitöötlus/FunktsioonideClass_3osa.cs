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
                kuude_list[0] = "Veeel kuuu";

            Console.WriteLine("--------------Kustutasime juuni-----------");
        }

    public static void 
    }
}
