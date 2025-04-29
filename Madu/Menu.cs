using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle; // библиотека для вывода текста в стиле ASCII

namespace TARgv24_C_Sharp.Madu
{
    /* Класс Menu отвечает за отображение главного меню игры "Змейка" и обработку выбора игрока */
    public class Menu
    {
        private static string[] options = { "PLAY", "LEADERBOARD", "SETTINGS", "EXIT" };  // варианты меню

        // метод для отображения меню и обработки выбора игрока
        public static int ShowMenu()
        {
            int selectedIndex = 0;  // индекс текущего выбранного пункта меню
            ConsoleKey key;  // переменная для хранения нажатой клавиши

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n\n");
                Console.WriteLine(FiggleFonts.Standard.Render("Snake Game"));
                Console.WriteLine();

                // вывод всех пунктов меню
                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedIndex)  // если это выбранный пункт
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"[ {options[i]} ]"); // текущий выбранный пункт
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine($"  {options[i]}");  // остальные пункты обычным цветом
                    }
                }

                Console.ResetColor();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);  // считываем нажатую клавишу
                key = keyInfo.Key;  // сохраняем нажатую клавишу

                // обработка нажатия стрелок
                if (key == ConsoleKey.UpArrow)  // стрелка вверх
                {
                    selectedIndex--;
                    if (selectedIndex < 0)
                        selectedIndex = options.Length - 1;  // если вышли за верхний предел — переходим в конец
                }
                else if (key == ConsoleKey.DownArrow)  // стрелка вниз
                {
                    selectedIndex++;
                    if (selectedIndex >= options.Length)
                        selectedIndex = 0;  // если вышли за нижний предел — переходим в начало
                }

            } while (key != ConsoleKey.Enter);  // продолжаем пока не нажата Enter

            return selectedIndex + 1; // возвращаем 1 для Play, 2 для Score Board и т.д.
        }
    }
}
