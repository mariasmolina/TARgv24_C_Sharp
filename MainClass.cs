using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello World! Привет! Tere päevast!");
            // I. osa Andmetüübid, If, Case, Random, Alamfunktsioonid
            int a = 0;
            string tekst = "Python";
            char taht = 'A';
            double arv = 5.45435333353;
            float arv1 = 2;
            Console.Write("Mis on sinu nimi? ");
            tekst = Console.ReadLine();
            Console.WriteLine("Tere!\n"+tekst);
            Console.WriteLine("\nTere {0}!",tekst);
            Console.WriteLine("Arv 2: ");
            int arv2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
            arv1=FunktsioonideClass.Kalkulaator(a, arv2);
            Console.WriteLine(arv1);

        }
    }
}
