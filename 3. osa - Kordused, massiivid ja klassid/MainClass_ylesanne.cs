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

            (int[] ruudud, int[] arvud) = ArvuTöötlus.GenereeriRuudud(-100, 100); // получаем два массива

            for (int i = 0; i < ruudud.Length; i++)
            {
                Console.WriteLine($"{arvud[i]} -> {ruudud[i]}");
            }

            Console.ReadKey();



            /************************************************************/
            // Ülesanne 2 - "Osta elevant ära!"

        }
    }
}
