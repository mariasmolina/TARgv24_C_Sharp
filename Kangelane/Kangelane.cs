using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_Sharp.Kangelane
{
    class Kangelane
    {
        private string nimi;
        private string asukoht;

        public string Nimi { get; set; }
        public string Asukoht { get; set; }

        // конструктор 
        public Kangelane(string nimi, string asukoht)
        {
            Nimi = nimi;
            Asukoht = asukoht;
        }

        // метод возвращает 95% от числа людей в опасности (округлённо)
        public virtual int Paasta(int ohus)
        {
            int protsent_ohus = (int)Math.Round(ohus * 0.95);

            return protsent_ohus;
        }

        // метод возвращает строку с описанием костюма героя
        public virtual string Vormiriietus()
        {
            string riietus = "Tavaline kangelase kostüüm – mask ja mantel";

            return riietus;
        }

        // метод возвращает персональное приветствие
        public virtual string Tervitus()
        {
            string tervitus = "Tere! Mina olen " + Nimi + "ja ma olen kangelane!";

            return tervitus;
        }

        // метод возвращает строку с статусом героя
        public virtual string MissiooniStaatus()
        {
            string staatus = $"{Nimi} on saadaval missiooniks!";

            return staatus;
        }

        // метод возвращает описание героя
        public override string ToString()
        {
            string kirjeldus = $"{Nimi} on kangelane, kes asub {Asukoht} ja on valmis päästma inimesi hädast!";

            return kirjeldus;
        }


    }
}
