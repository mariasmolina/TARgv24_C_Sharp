using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace TARgv24_C_Sharp.Madu
{
    /* Класс Levels — отображает меню выбора уровня сложности */
    public class LevelSelector
    {
        public string[] Levels { get; set; }
        public int SelectedLevel { get; set; }

        // Конструктор
        public LevelSelector()
        {
            Levels = new string[] { "EASY", "MEDIUM", "HARD", "HELL" };
            SelectedLevel = 1; // значение по умолчанию
        }

        // Метод для выбора уровня
        public void Choose()
        {
            string title = FiggleFonts.Standard.Render("SELECT LEVEL\n");
            int choice = Keyboard.ChooseOption(title, Levels);
            SelectedLevel = choice;
        }

        // Метод для получения названия выбранного уровня
        public string GetSelectedLevelName()
        {
            return Levels[SelectedLevel - 1];
        }
    }
}
