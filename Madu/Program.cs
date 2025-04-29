using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

// OOP - инкапсуляция, наследование, полиморфизм

namespace TARgv24_C_Sharp.Madu
{
    /* Класс Program запускает игру "Змейка": создаёт стены, змейку и еду,
     обрабатывает столкновения, нажатия клавиш и выводит экран окончания игры */
    class Program
    {
        static void Main(string[] args)
        {
            // устанавливаем размер консоли
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Params par = new Params();
            Sounds sounds = new Sounds(par.GetResourceFolder());
            Settings.GlobalSounds = sounds;  // сохраняем объект звуков в настройки
            sounds.Play(); // фоновая музыка

            Menu.ShowFullMenu(sounds); // показываем меню

        }

            // метод для запуска игры
            public static void StartGame(Sounds sounds) 
            {
                // выбор уровня сложности
                int level = Levels.ChooseLevel();
                int snakeSpeed = Speed.SnakeSpeed(level);

                // спрашиваем имя игрока и создаём объект Score
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                string title=FiggleFonts.Standard.Render("PLAYER");
                Console.WriteLine(title);
                Console.Write("\nENTER YOUR NAME: ");
                string playerName = Console.ReadLine();
                Console.Clear();
                Score score = new Score(playerName);

 
                // создаём переменную, которая отвечает за сложный уровень
                bool isHardLevel = false;

                // если выбран уровень 4 (оочень сложный), то ставим true
                if (level == 4)
                {
                    isHardLevel = true;
                }
                // создаём стены, передавая флаг сложности
                Walls walls = new Walls(80, 25, isHardLevel);
                Console.ForegroundColor = Settings.WallColor;
                walls.Draw();
                Console.ResetColor();

            // Отрисовка точек
            Point p = new Point(4, 5, '*');  // x, y, символ
                Snake snake = new Snake(p, 4, Direction.RIGHT);  // координаты, длина и направление
                Console.ForegroundColor = Settings.SnakeColor;
                snake.Draw();
                Console.ResetColor();

            FoodCreator foodCreator = new FoodCreator(80, 25, Settings.FoodChar);
                Point food = foodCreator.CreateFood();
                food.Draw();

                while (true)
                {
                    // проверка столкновения змейки об стену или с хвостом
                    if (walls.IsHit(snake) || snake.IsHitTail())
                    {
                        sounds.Stop("music");
                        sounds.Play("gameover"); // проигрываем звук конца игры
                        Thread.Sleep(2000);
                        break;
                    }

                    if (snake.Eat(food)) // если змейка встретится с едой
                    {
                        sounds.PlayEat(); // воспроизводим звук поедания еды
                        food = foodCreator.CreateFood();
                        food.Draw();
                        score.Add(10);
                    }
                    else
                    {
                        snake.Move();
                    }
                    Thread.Sleep(snakeSpeed); // задержка между движениями змейки

                    if (Console.KeyAvailable)  // обработка нажатия клавиш
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snake.HandleKey(key.Key);
                    }
                }

                WriteGameOver(playerName, score.Points);
                Keyboard.WaitForEsc();
                score.Save();
                sounds.Play(); // продолжаем воспроизводить фоновую музыку
            }


        // метод для вывода текста в консоли
        public static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

        // выводит сообщение об окончании игры в консоли
        static void WriteGameOver(string playerName, int points)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            string title = FiggleFonts.Standard.Render("   G A M E    O V E R");
            Console.WriteLine(title);

            int xOffset = 25;
            int yOffset = 7;

            Console.SetCursorPosition(xOffset, yOffset++);

            WriteText("============================", xOffset, yOffset++);
            yOffset++;
            WriteText($"PLAYER: {playerName}", xOffset + 9, yOffset++);
            WriteText($"SCORE: {points}", xOffset + 10, yOffset++);
            yOffset++;
            WriteText("============================", xOffset, yOffset++);
            WriteText("Student: Maria Smolina", xOffset + 3, yOffset++);
            WriteText("Game - Snake", xOffset + 8, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            yOffset += 5;
            WriteText("Press ESC to return to MENU", xOffset, yOffset++);
        }
    }
}
