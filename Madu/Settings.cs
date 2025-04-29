using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace TARgv24_C_Sharp.Madu
{
    /* Класс Settings отвечает за настройки игры: цвет змейки, цвет стен,
     символ еды, громкость музыки и т.д. */
    public static class Settings
    {
        public static ConsoleColor SnakeColor = ConsoleColor.Green;
        public static ConsoleColor WallColor = ConsoleColor.White;
        public static char FoodChar = '$';
        public static int BackgroundVolume = 10;
        public static Sounds GlobalSounds;  // объект звуков для фоновой музыки

        public static void ShowSettings()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                string title = FiggleFonts.Standard.Render("SETTINGS");
                string[] settingsOptions = { "Snake Color", "Wall Color", "Food Symbol", "Background Volume", "<- Back to Menu" };
                int choice = Keyboard.ChooseOption(title, settingsOptions);

                if (choice == 1)
                    ChooseSnakeColor();
                else if (choice == 2)
                    ChooseWallColor();
                else if (choice == 3)
                    ChooseFoodSymbol();
                else if (choice == 4)
                    ChooseBackgroundVolume();
                else if (choice == 5)
                    break; // выходим в главное меню
            }
        }

        static void ChooseSnakeColor()
        {
            ConsoleColor[] colors = {
                ConsoleColor.Red,
                ConsoleColor.Blue,
                ConsoleColor.Green,
                ConsoleColor.Yellow,
                ConsoleColor.Cyan,
                ConsoleColor.Magenta,
                ConsoleColor.White,
                ConsoleColor.DarkYellow,
                ConsoleColor.DarkBlue
            };

            string[] colorNames = { "Red", "Blue", "Green", "Yellow", "Cyan", "Magenta", "White", "DarkYellow", "DarkBlue" };

            Console.Clear();
            string title = "Choose Snake Color\n";

            int index = Keyboard.ChooseOption(title, colorNames);
            SnakeColor = colors[index - 1];  // сохраняем выбранный цвет
        }

        static void ChooseWallColor()
        {
            ConsoleColor[] colors = {
                ConsoleColor.Red,
                ConsoleColor.Blue,
                ConsoleColor.Green,
                ConsoleColor.Yellow,
                ConsoleColor.Cyan,
                ConsoleColor.Magenta,
                ConsoleColor.White,
                ConsoleColor.DarkYellow,
                ConsoleColor.DarkBlue
            };

            string[] colorNames = { "Red", "Blue", "Green", "Yellow", "Cyan", "Magenta", "White", "DarkYellow", "DarkBlue" };

            Console.Clear();
            string title = "Choose Wall Color\n";

            int index = Keyboard.ChooseOption(title, colorNames);
            WallColor = colors[index - 1];  // сохраняем выбранный цвет
        }

        static void ChooseFoodSymbol()
        {
            Console.Clear();
            char[] symbols = { '@', '#', '$', '%', '&', '*', '+', '=', '?' };
            string title = "Choose Food Symbol\n";

            string[] symbolNames = Array.ConvertAll(symbols, c => c.ToString()); // преобразуем char[] в string[]

            int index = Keyboard.ChooseOption(title, symbolNames);
            FoodChar = symbols[index - 1];
        }


        static void ChooseBackgroundVolume()
        {
            Console.Clear();
            Console.WriteLine("Set Background Volume (0-100): ");

            try
            {
                string input = Console.ReadLine();
                int volume = int.Parse(input);  // преобразуем строку в число

                if (volume >= 0 && volume <= 100)
                {
                    BackgroundVolume = volume;
                    GlobalSounds.UpdateVolume();  // обновляем громкость
                }
                else
                {
                    Console.WriteLine("Volume must be between 0 and 100!");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("You must enter a number!");
            }
        }
    }
}
