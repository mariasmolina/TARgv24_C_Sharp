using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace TARgv24_C_Sharp.Madu
{
    /* Класс Game управляет всей логикой игры "Змейка":
     * выбирает уровень сложности, создаёт стены, змейку и еду,
     * обрабатывает столкновения и выводит экран окончания игры */
    public class Game
    {
        private Sounds GlobalSounds;  // объект звуков, передаётся через конструктор

        // конструктор принимает объект звуков
        public Game(Sounds sounds)
        {
            GlobalSounds = sounds;
        }

        // основной метод для запуска игры
        public void Start()
        {
            // выбор уровня сложности
            LevelSelector levelSelector = new LevelSelector();
            levelSelector.Choose();
            int level = levelSelector.SelectedLevel;

            Speed speed = new Speed(level);
            int snakeSpeed = speed.SpeedValue;

            // спрашиваем имя игрока и создаём объект Score
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            string title = FiggleFonts.Standard.Render("PLAYER");
            Console.WriteLine(title);
            Console.Write("\nENTER YOUR NAME: ");
            string playerName = Console.ReadLine();
            Console.Clear();
            Score score = new Score(playerName);

            // создаём переменную, которая отвечает за сложный уровень
            bool isHardLevel = (level == 4);  // true если выбрали 4 уровень

            // создаём стены и отрисовываем их
            Walls walls = new Walls(80, 25, isHardLevel);
            Console.ForegroundColor = Settings.WallColor;
            walls.Draw();
            Console.ResetColor();

            // создаём змейку и отрисовываем её
            Point p = new Point(4, 5, '*');  // начальная точка змейки
            Snake snake = new Snake(p, 4, Direction.RIGHT);  // координаты, длина, направление
            Console.ForegroundColor = Settings.SnakeColor;
            snake.Draw();
            Console.ResetColor();

            // создаём еду и отрисовываем
            FoodCreator foodCreator = new FoodCreator(80, 25, Settings.FoodChar);
            Point food = foodCreator.CreateFood();
            food.Draw();

            // основной цикл игры
            while (true)
            {
                // проверка столкновения змейки со стеной или с хвостом
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    GlobalSounds.Stop("music");
                    GlobalSounds.Play("gameover");  // звук окончания игры
                    Thread.Sleep(2000);
                    break;
                }

                if (snake.Eat(food))  // если змейка ест еду
                {
                    GlobalSounds.PlayEat();  // звук поедания еды
                    food = foodCreator.CreateFood();  // создаём новую еду
                    food.Draw();
                    score.Add(10);  // добавляем очки
                }
                else
                {
                    snake.Move();  // просто двигаем змейку
                }

                Thread.Sleep(snakeSpeed);  // задержка по скорости уровня

                if (Console.KeyAvailable)  // если нажата клавиша
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);  // обрабатываем нажатие
                }
            }

            // показываем экран окончания игры
            WriteGameOver(playerName, score.Points);

            Keyboard.WaitForEsc();  // ждём ESC для выхода
            score.Save();  // сохраняем результат

            GlobalSounds.Play();  // запускаем фоновую музыку снова
        }

        // метод для вывода текста на экране с позиционированием
        public static void WriteText(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

        // метод для вывода экрана окончания игры
        private void WriteGameOver(string playerName, int points)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            string title = FiggleFonts.Standard.Render("   G A M E    O V E R");
            Console.WriteLine(title);

            int xOffset = 25;
            int yOffset = 7;

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
