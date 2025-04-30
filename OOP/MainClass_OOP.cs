using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp.OOP
{
    internal class MainClass_OOP
    {
        static void Main(string[] args)
        {
            // 1. Klass - шаблон для создания объектов
            Inimene inimene = new Inimene();
            inimene.Nimi = "Jaan";
            inimene.Vanus = 30;
            inimene.Tervita();

            // 2. Pärilus (inheritance) - подкласс наследует свойства и методы родителя
            Töötaja töötaja = new Töötaja();
            töötaja.Nimi = "Mari";
            töötaja.Vanus = 25;
            töötaja.Ametikoht = "Programmeerija";
            töötaja.Tervita();
            töötaja.Töötan();

            // 3. Abstraktsioon (abstraction) - скрывает детали, показывает только важное
            Loom loom = new Koer();
            loom.Nimi = "Rex";
            loom.TeeHääl();
            Console.Write($"{loom.Nimi} ütleb: ");
            loom.TeeHääl();

            // 4. Kapseldamine (encapsulation) - защита данных, контролируемый доступ
            Pank pank = new Pank();
            pank.Saldo = 1000;
            Console.WriteLine($"Panga saldo: {pank.Saldo}");
            // проверка на отрицательное значение
            pank.Saldo = -500; // не изменит значение, так как оно меньше 0
            Console.WriteLine($"Panga saldo: {pank.Saldo}"); // Saldo jääb 1000-ks

            // 5.Liides(interface) - как договор – определяет, какие методы должны быть реализованы
            IHeliline kass = new Kass();
            kass.TeeHääl();
            Console.WriteLine("Kass ütleb: ");
            kass.TeeHääl();

            Console.ReadKey();
        }
    }
}
