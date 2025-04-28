using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp._5._osa___Kollektsioonid._Listid_ja_sõnastikud
{
    internal class Opilane
    {
        public string Nimi { get; set; }
        public List<int> Hinded { get; set; }

        // Вычисляет и возвращает среднюю оценку ученика
        public double ArvutaKeskmine()
        {
            double summa = 0;
            foreach (int hinne in Hinded)
            {
                summa = summa + hinne;
            }
            return summa / Hinded.Count;
        }
    }
}
