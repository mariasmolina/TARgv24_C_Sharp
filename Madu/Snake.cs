using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
        
        public Point GetNextPoint()
        {
            Point head = pList.Last();  // текущая позиция головы змейки, до того, как она переместилась
            Point nextPoint = new Point(head); // создана копия точки (предыдущего положения головы)
            nextPoint.Move(1, direction);
            return nextPoint;  // новое положение головы змейки
        }
    }
}
