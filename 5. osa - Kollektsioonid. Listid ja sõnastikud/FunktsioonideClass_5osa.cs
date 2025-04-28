using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp._5._osa___Kollektsioonid._Listid_ja_sõnastikud
{
    internal class FunktsioonideClass_5osa
    {
        // Словарь для хранения областей и столиц
        private static Dictionary<string, string> maakonnad = new Dictionary<string, string>()
        {
            { "Harjumaa", "Tallinn" },
            { "Tartumaa", "Tartu" },
            { "Pärnumaa", "Pärnu" }
        };

        // Поиск области или столицы
        public static void OtsiMaakondLinn() 
        {
            Console.WriteLine("Sisesta maakonna või linna nimi:");
            string sisend = Console.ReadLine();

            if (maakonnad.ContainsKey(sisend))
            {
                Console.WriteLine($"Maakonna {sisend} pealinn on {maakonnad[sisend]}.");
            }
            else if (maakonnad.ContainsValue(sisend))
            {
                foreach (var paar in maakonnad)
                {
                    if (paar.Value == sisend)
                    {
                        Console.WriteLine($"Linn {sisend} asub maakonnas {paar.Key}.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Andmeid ei leitud");
            }
        }

        // Добавить новую область и столицу
        public static void LisaUusMaakond()
        {
            Console.WriteLine("Sisesta uue maakonna nimi:");
            string uusMaakond = Console.ReadLine();
            Console.WriteLine("Sisesta selle maakonna pealinn:");
            string uusLinn = Console.ReadLine();

            if (maakonnad.ContainsKey(uusMaakond))
            {
                Console.WriteLine("See maakond on juba olemas.");
            }
            else
            {
                maakonnad.Add(uusMaakond, uusLinn);
                Console.WriteLine("Uus maakond on lisatud.");
            }
        }


        // Игровой режим, где спрашивается столица случайной области и в конце показывается процент правильных ответов
        public static void ManguReziim()
        {
            Random rnd = new Random();
            List<string> maakonnaNimed = new List<string>(maakonnad.Keys);

            int kokkuKysimusi = 5; // сколько будет вопросов (например, 5)
            int õigedVastused = 0; // сколько правильных ответов дал пользователь

            for (int i = 0; i < kokkuKysimusi; i++)
            {
                // Выбираем случайную область
                string juhuslikMaakond = maakonnaNimed[rnd.Next(maakonnaNimed.Count)];
                string oigeVastus = maakonnad[juhuslikMaakond];

                // Спрашиваем пользователя
                Console.WriteLine($"Mis on maakonna {juhuslikMaakond} pealinn?");
                string kasutajaVastus = Console.ReadLine();

                // Сравниваем ответы
                if (kasutajaVastus == oigeVastus || kasutajaVastus.ToLower() == oigeVastus.ToLower())
                {
                    Console.WriteLine("Õige vastus!\n");
                    õigedVastused = õigedVastused + 1; // увеличиваем счётчик правильных ответов
                }
                else
                {
                    Console.WriteLine($"Vale vastus! Õige vastus oli: {oigeVastus}\n");
                }
            }

            // Вычисляем процент правильных ответов
            double protsent = Math.Round((double)õigedVastused / kokkuKysimusi * 100); // округляем до целого числа
            Console.WriteLine($"Mäng lõppes! Sa said {õigedVastused} õiget vastust {kokkuKysimusi}st.");
            Console.WriteLine($"Sinu tulemus on {protsent}%.");
        }

        // Kuva kõik maakonnad ja nende pealinnad
        public static void KuvaKoik()
        {
            Console.WriteLine("\nKõik maakonnad ja nende pealinnad:");
            foreach (var paar in maakonnad)
            {
                Console.WriteLine($"{paar.Key} - {paar.Value}");
            }
        }
    }
}   

