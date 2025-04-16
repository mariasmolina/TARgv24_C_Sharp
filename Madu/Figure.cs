using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp.Madu
{
    /* Класс Figure — хранит список точек pList, предоставляет методы для отрисовки фигуры и проверки пересечений */
    class Figure   // базовый класс, по отношению к его наследникам (Snake, HorizontalLine, VerticalLine)
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        // проверяет пересечение с другой фигурой
        internal bool IsHit(Figure figure)  // принимает фигуру
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        // проверяет пересечение с конкретной точкой
        private bool IsHit(Point point)  // принимает точку
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
