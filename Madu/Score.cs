using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp.Madu
{
    /* Класс Score отвечает за ведение счёта в игре.
     Он хранит имя игрока и количество очков, а также предоставляет методы для добавления очков,
     отображения счёта, сохранения результатов в файл, сортировки и вывода таблицы лидеров на экран */
    internal class Score
    {
        public string PlayerName { get; set; } // имя игрока
        public int Points { get; set; } // количество очков
        public string filePath;

        // конструктор класса Score
        public Score(string playerName)
        {
            PlayerName = playerName;
            Points = 0;

            Params p = new Params();
            filePath = Path.Combine(p.GetResourceFolder(), "results.txt");
            Draw();
        }


        // метод для добавления очков 
        public void Add(int pointsAmount)
        {
            Points += pointsAmount; // добавляем очки
            Draw();
        }


        // метод для отображения очков в консоли
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;  // устанавливаем красный цвет текста
            Console.SetCursorPosition(0, 0); // устанавливаем позицию курсора
            Console.Write($"Score: {Points} ");
            Console.ResetColor(); // возвращаем стандартный цвет текста
        }


        // метод для сохранения результата в файл
        public void Save()
        {
            List<Score> players = new List<Score>(); // создаём список игроков
            bool updated = false; // флажок: обновили ли результат игрока

            // читаем все строки из файла
            string[] lines = File.ReadAllLines(filePath);

            // перебираем все строки
            foreach (string line in lines)
            {
                string[] parts = line.Split(':'); // разделяем строку на имя и очки
                if (parts.Length == 2)
                {
                    string nimi = parts[0]; // имя игрока
                    int punktid = int.Parse(parts[1]); // очки игрока

                    // добавляем игрока в список
                    players.Add(new Score(nimi) { Points = punktid });
                }
            }

            // ищем, есть ли уже игрок с таким именем
            foreach (Score player in players)
            {
                if (player.PlayerName == PlayerName)
                {
                    // если новые очки больше старых, обновляем
                    if (Points > player.Points)
                    {
                        player.Points = Points;
                    }
                    updated = true; // игрок найден
                    break;
                }
            }

            // если игрока не нашли — добавляем нового
            if (!updated)
            {
                players.Add(new Score(PlayerName) { Points = Points });
            }

            // сортируем список по очкам от большего к меньшему
            players.Sort((a, b) => b.Points.CompareTo(a.Points));

            // перезаписываем файл новыми строками
            using (StreamWriter scoreBoard = new StreamWriter(filePath)) 
            {
                foreach (Score player in players)
                {
                    scoreBoard.WriteLine(player.PlayerName + ":" + player.Points);
                }
            }
        }


        // метод для показа таблицы лидеров
        public static void showLeaderoard()
        {
            try
            {
                // Чтение и заполнение словаря
                Params p = new Params();
                string path = Path.Combine(p.GetResourceFolder(), "results.txt");

                string[] lines = File.ReadAllLines(path); // читаем строки из файла

                // выводим отсортированные результаты
                Console.Clear();
                int xOffset = 25;
                int yOffset = 8;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.SetCursorPosition(xOffset, yOffset++);
                Program.WriteText("============================", xOffset, yOffset++);
                Program.WriteText("     TULEMUSED", xOffset + 5, yOffset++); // Заголовок по центру
                yOffset++; // отступ

                foreach (var line in lines)
                {
                    Program.WriteText(line, xOffset + 10, yOffset++); // выводим результаты
                }

                Program.WriteText("============================", xOffset, yOffset++);
                yOffset += 5;
                Program.WriteText("Press ESC to return to MENU", xOffset, yOffset++);
                Console.ResetColor(); // Вернуть обычный цвет
                Keyboard.WaitForEsc(); // ждём нажатие ESC
            }
            catch (Exception)
            {
                Console.WriteLine("Viga tulemuste lugemisel.");
            }
        }
    }
}
