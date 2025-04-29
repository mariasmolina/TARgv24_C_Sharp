using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp.Madu
{
    // Класс Speed отвечает за скорость змейки в зависимости от уровня сложности
    public static class Speed
    {
        public static int SnakeSpeed(int level)
        {
            if (level == 1)
            {
                return 150; // лёгкий (150 мс между движениями)
            }
            else if (level == 2)
            {
                return 100; // средний
            }
            else if (level == 3)
            {
                return 50;  // сложный
            }
            else
            {
                return 100; // по умолчанию средний
            }
        }
    }
}
