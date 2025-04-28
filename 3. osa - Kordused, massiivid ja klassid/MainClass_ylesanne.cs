using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp._3._osa___Kordused__massiivid_ja_klassid
{
    internal class MainClass_ylesanne
    {
        public static void Main(string[] args)
        {
            /************************************************************/
            // Ülesanne 1 - Juhuslike arvude ruudud (Случайные квадраты чисел)

            //(int[] ruudud, int[] arvud) = ArvuTöötlus.GenereeriRuudud(-100, 100); // получаем два массива

            //for (int i = 0; i < ruudud.Length; i++)
            //{
            //    Console.WriteLine($"{arvud[i]} -> {ruudud[i]}");
            //}

            //Console.ReadKey();



            /************************************************************/
            // Ülesanne 4 - "Osta elevant ära!"
            static void KuniMärksõnani(string märksõna, string fraas)
            {
                List<string> vastused = new List<string>();
                string sisend;
                do
                {
                    Console.Write($"\n{fraas}\nSisesta märksõna: ");
                    sisend = Console.ReadLine();
                    vastused.Add(sisend);

                    if (sisend == märksõna)
                    {
                        Console.WriteLine("Õige vastus, tubli!");
                    }

                } while (sisend != märksõna);

                Console.WriteLine("\nKõik sisetatud vastused:");
                foreach (var vastus in vastused)
                {
                    Console.WriteLine(vastus);
                }
            }

            KuniMärksõnani("elevant", "Osta elevant ära!");



            /************************************************************/
            // Ülesanne 5 - Arvamise mäng




            Console.ReadKey();
        }
    }
}
