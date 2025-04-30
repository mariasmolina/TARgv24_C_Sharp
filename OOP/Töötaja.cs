using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp.OOP
{
    public class Töötaja : Inimene
    {
        public string Ametikoht;

        public void Töötan()
        {
            Console.WriteLine($"{Nimi} töötab ametikohal {Ametikoht}.");
        }
    }


}
