using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp.OOP
{
    public class Kass : IHeliline
    {
        public void TeeHääl()
        {
            Console.WriteLine("Mjäu!");
        }
    }
    public interface IHeliline
    {
        void TeeHääl();
    }
}
