using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp.Madu
{
    // Класс Speed отвечает за скорость змейки в зависимости от уровня сложности
    public class Speed
    {
        public int SpeedValue { get; set; }
        public int DefaultSpeed { get; set; } = 100;

        // Конструктор
        public Speed(int level)
        {
            SetSpeed(level);
        }

        // Метод для установки скорости
        private void SetSpeed(int level)
        {
            if (level == 1)
            {
                SpeedValue = 150;
            }
            else if (level == 2)
            {
                SpeedValue = 100;
            }
            else if (level == 3)
            {
                SpeedValue = 50;
            }
            else if (level == 4)
            {
                SpeedValue = 35;
            }
            else
            {
                SpeedValue = DefaultSpeed;
            }
        }
    }

}
