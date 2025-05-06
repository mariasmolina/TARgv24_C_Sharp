using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

// OOP - инкапсуляция, наследование, полиморфизм

namespace TARgv24_C_Sharp.Madu
{
    /* Класс Program запускает игру */
    class Program
    {
        static void Main(string[] args)
        {
            // устанавливаем размер консоли
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Params par = new Params();
            Sounds sounds = new Sounds(par.GetResourceFolder());
            Settings.GlobalSounds = sounds;  // сохраняем объект звуков в настройки
            sounds.Play(); // фоновая музыка

            Menu.ShowFullMenu(sounds); // показываем меню
        }
    }
}
