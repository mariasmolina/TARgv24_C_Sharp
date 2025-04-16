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
                    break;
                }

                if (snake.Eat(food)) // если змейка встретится с едой
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)  // обработка нажатия клавиш
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}
