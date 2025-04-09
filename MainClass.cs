using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //Console.WriteLine("Hello World! Привет! Tere päevast!");
            //// I. osa Andmetüübid, If, Case, Random, Alamfunktsioonid
            //int a = 0;
            //string tekst = "Python";
            //char taht = 'A';
            //double arv = 5.45435333353;
            //float arv1 = 2;
            //Console.Write("Mis on sinu nimi? ");
            //tekst = Console.ReadLine();
            //Console.WriteLine("Tere!\n"+tekst);
            //Console.WriteLine("\nTere {0}!",tekst);

            //// C# Valikute konstruktsionid
            //if (tekst.ToLower() == "juku")
            //{
            //    Console.WriteLine("Lähme kinno!");
            //    try
            //    {
            //        Console.WriteLine("{0}\n Kui vana sa oled?", tekst);
            //        int vanus = int.Parse(Console.ReadLine());
            //        if (vanus <= 0 || vanus > 100)  // && - and, || - or
            //        {
            //            Console.WriteLine("Viga!");
            //        }
            //        else if (vanus > 0 && vanus <= 6)
            //        {
            //            Console.WriteLine("Tasuta");
            //        }
            //        else if (vanus < 15)
            //        {
            //            Console.WriteLine("Lastepilet");
            //        }
            //        else if (vanus >= 15 && vanus < 65)
            //        {
            //            Console.WriteLine("Täispilet!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sooduspilet!");
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //    }
            //}
            //else
            //{
            //     Console.WriteLine("Olen hõivatud");
            //}

            //Console.WriteLine("Arv 2: ");
            //int arv2 = int.Parse(Console.ReadLine());
            //// Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
            //arv1=FunktsioonideClass.Kalkulaator(a, arv2);
            //Console.WriteLine(arv1);

            //Console.WriteLine("Switch'i kasutamine");
            //Random rnd = new Random();
            //a = rnd.Next(1, 7);
            //Console.WriteLine(a);

            //tekst = FunktsioonideClass.switchKasuta(a);
            //Console.WriteLine(tekst);

            //Console.ReadKey();

            // Küsi kahe inimese nimed ning teata, et nad on täna pinginaabrid
            Console.Write("Sisesta esimene nimi:");
            string nimi1 = Console.ReadLine();
            Console.Write("Sisesta teine nimi:");
            string nimi2 = Console.ReadLine();
            string tekst = FunktsioonideClass.Pinginaabrid(nimi1, nimi2);
            Console.WriteLine(tekst);

            // Küsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala.
            // Küsi kasutajalt remondi tegemise soov, kui ta on positiivne, siis küsi kui palju maksab ruutmeeter ja leia põranda vahetamise hind
            Console.Write("Sisestage esimese seina pikkus:");
            float a = int.Parse(Console.ReadLine());
            Console.Write("Sisestage teise seina pikkus:");
            float b = Console.ReadLine();

        }
    }
}
