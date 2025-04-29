using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// OOP - инкапсуляция, наследование, полиморфизм

namespace TARgv24_C_Sharp.Madu
{
    /* Класс Program запускает игру "Змейка": создаёт стены, змейку и еду,
     обрабатывает столкновения, нажатия клавиш и выводит экран окончания игры */
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Params par = new Params();
            Sounds sounds = new Sounds(par.GetResourceFolder());
            sounds.Play(); // фоновая музыка

            Menu.ShowFullMenu(sounds); // показываем меню

        }

            // метод для запуска игры
            public static void StartGame(Sounds sounds) 
            {
                // спрашиваем имя игрока и создаём объект Score
                Console.Clear();
                Console.SetCursorPosition(30, 10);
                Console.Write("Sisesta oma nimi: ");
                string playerName = Console.ReadLine();
                Console.Clear();
                Score score = new Score(playerName);

                Walls walls = new Walls(80, 25);
                walls.Draw();

                // Отрисовка точек
                Point p = new Point(4, 5, '*');  // x, y, символ
                Snake snake = new Snake(p, 4, Direction.RIGHT);  // координаты, длина и направление
                snake.Draw();

                FoodCreator foodCreator = new FoodCreator(80, 25, '$');
                Point food = foodCreator.CreateFood();
                food.Draw();

                while (true)
                {
                    if (walls.IsHit(snake) || snake.IsHitTail())  // проверка столкновения змейки об стену или с хвостом
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
                    Thread.Sleep(100); // задержка между движениями змейки

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
            int xOffset = 25;
            int yOffset = 5;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("G A M E    O V E R", xOffset + 5, yOffset++);
            yOffset++;
            WriteText($"Player: {playerName}", xOffset + 5, yOffset++);
            WriteText($"Score: {points}", xOffset + 5, yOffset++);
            yOffset++;
            yOffset++;
            WriteText("============================", xOffset, yOffset++);
            WriteText("Student: Maria Smolina", xOffset + 3, yOffset++);
            WriteText("Game - Snake", xOffset + 8, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            yOffset++;
            yOffset++;
            yOffset++;
            WriteText("Press ESC to return to menu", xOffset, yOffset++);
        }
    }
}
