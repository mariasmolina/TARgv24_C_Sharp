﻿using System;
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
            //static void KuniMärksõnani(string märksõna, string fraas)
            //{
            //    List<string> vastused = new List<string>();
            //    string sisend;
            //    do
            //    {
            //        Console.Write($"\n{fraas}\nSisesta märksõna: ");
            //        sisend = Console.ReadLine();
            //        vastused.Add(sisend);

            //        if (sisend == märksõna)
            //        {
            //            Console.WriteLine("Õige vastus, tubli!");
            //        }

            //    } while (sisend != märksõna);

            //    Console.WriteLine("\nKõik sisetatud vastused:");
            //    foreach (var vastus in vastused)
            //    {
            //        Console.WriteLine(vastus);
            //    }
            //}

            //KuniMärksõnani("elevant", "Osta elevant ära!");



            /************************************************************/
            // Ülesanne 5 - Arvamise mäng

            //static void ArvaArv()
            //{
            //    Random rnd = new Random();
            //    int arv = rnd.Next(1, 101);
            //    int katsed = 5;
            //    int vastus;

            //    do
            //    {
            //        Console.Write("Arva ära arv (1-100): ");
            //        vastus = int.Parse(Console.ReadLine());

            //        if (vastus > arv) Console.WriteLine("Liiga suur!");
            //        else if (vastus < arv) Console.WriteLine("Liiga väike!");
            //        else
            //        {
            //            Console.WriteLine("\nÕige arv!");
            //            return;
            //        }
            //        katsed--;
            //    } while (katsed > 0);

            //    Console.WriteLine($"\nKaotasid! Õige arv oli {arv}");
            //}

            //ArvaArv();



            /************************************************************/
            // Ülesanne 9 - Arvude ruudud

            int[] arvud = { 2, 4, 6, 8, 10, 12 };

            // Ruut (for)
            for (int i = 0; i < arvud.Length; i++)
                Console.WriteLine($"{arvud[i]} ruut on {arvud[i] * arvud[i]}");

            // Kahekordne väärtus (foreach)
            foreach (var arv in arvud)
                Console.WriteLine($"{arv} kahekordne väärtus on {arv * 2}");

            // Kui palju on arvude seas arve, mis jaguvad 3-ga (while)
            int arvudeKogus = 0;
            int jaguvadKolmega = 0;
            while (arvudeKogus < arvud.Length)
            {
                if (arvud[arvudeKogus] % 3 == 0)  // делятся на 3 без остатка
                    jaguvadKolmega++;

                arvudeKogus++;
            }
            Console.WriteLine($"Kolmega jaguvate arvude koguarv: {jaguvadKolmega}");

            Console.WriteLine("Arvud, mis jaguvad kolmega:");
            for (int i = 0; i < arvud.Length; i++)
            {
                if (arvud[i] % 3 == 0)
                {
                    Console.WriteLine(arvud[i]);
                }
            }




            Console.ReadKey();
        }
    }
}
