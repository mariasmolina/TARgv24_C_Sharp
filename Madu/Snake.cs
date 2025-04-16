using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TARgv24_C_Sharp.Madu
{
    class Snake : Figure
    {
        Direction direction;  // класс хранит данные - направление

        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();  // First() - возвращает первый элемент списка
            pList.Remove(tail);  
            Point head = GetNextPoint(); // найти объект - голова змейки
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }
        
        public Point GetNextPoint()  // вычисляет, в какой точке находится змейка в следующий момент
        {
            Point head = pList.Last();  // текущая позиция головы змейки, до того, как она переместилась
            Point nextPoint = new Point(head); // создана копия точки (предыдущего положения головы)
            nextPoint.Move(1, direction);
            return nextPoint;  // новое положение головы змейки
        }

        internal bool IsHitTail()  // проверка пересечения координат головы с координатами точек до хвоста
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))  // если голова змейки совпадает по координатам с едой
            {
                food.sym = head.sym;  // символ еды становится * и добавляется в список
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
