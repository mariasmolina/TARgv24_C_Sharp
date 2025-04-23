using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp._3._Failitöötlus
{
    internal class MainClass_3osa
    {
        public static void Main(string[] args)
        {
            // ------- Faili kirjutamine(StreamWriter) -------
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\opilane\\Source\\Repos\\TARgv24_C_Sharp\\3. Failitöötlus\\Kuud.txt"); //@"..\..\..\Kuud.txt"
                using (StreamWriter text = new StreamWriter(path, true))  // Fail suletakse automaatselt siin
                {
                    Console.WriteLine("Sisesta mingi tekst: ");
                    string lause = Console.ReadLine();
                    text.WriteLine(lause);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }


            // ------ Faili lugemine (StreamReader) --------
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\opilane\\Source\\Repos\\TARgv24_C_Sharp\\3. Failitöötlus\\Kuud.txt");
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }


            // ------ Ridade lugemine List<string> abil -------
            List<string> kuude_list = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\opilane\\Source\\Repos\\TARgv24_C_Sharp\\3. Failitöötlus\\Kuud.txt");
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }


            // ------ Listi muutmine ja kuvamine -------
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            // Eemalda "Juuni"
            kuude_list.Remove("Juuni");

            // Muuda esimest elementi
            if (kuude_list.Count > 0)
                kuude_list[0] = "Veeel kuuu";

            Console.WriteLine("--------------Kustutasime juuni-----------");

            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }


            // ------ Otsing nimekirjast -------
            Console.WriteLine("Sisesta kuu nimi, mida otsida:");
            string otsitav = Console.ReadLine();

            if (kuude_list.Contains(otsitav))
                Console.WriteLine("Kuu " + otsitav + " on olemas.");
            else
                Console.WriteLine("Sellist kuud pole.");


            // -----  Listi salvestamine tagasi faili ------
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
            File.WriteAllLines(path, kuude_list);
            Console.WriteLine("Andmed on salvestatud.");



            ///////////////////////////////////////////////////
            
            // ------ Ülesanne ------

        }
    }
}
