using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace TARgv24_C_Sharp.Madu
{
    /* Класс Levels — отображает меню выбора уровня сложности */
    public static class Levels
    {
        public static int ChooseLevel()
        {
            string[] levels = { "EASY", "MEDIUM", "HARD", "HELL" };

            string title = FiggleFonts.Standard.Render("SELECT LEVEL\n");
            return Keyboard.ChooseOption(title, levels); // возвращает 1, 2 или 3
        }
    }
}
