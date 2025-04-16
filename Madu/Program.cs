using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp.Madu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            // Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            // Отрисовка точек
            Point p = new Point(4, 5, '*');  // x, y, символ
            Snake snake = new Snake(p, 4, Direction.RIGHT);  // координаты, длина и направление
            snake.Drow();

            while (true)  // обработка нажатия клавиш
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep (100);
                snake.Move();
            }
        }
    }
}
