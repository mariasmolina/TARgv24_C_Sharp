using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TARgv24_C
{
    class FunktsioonideClass
    {
        public static float Kalkulaator(int arv1, int arv2)
        {
            float kalkulaator = 0;
            kalkulaator = arv1 * arv2;
            return kalkulaator;
        }

        public static string switchKasuta(int a)
        {
            string tekst;

            switch (a)
            {
                case 1: tekst = "Esmaspäev"; break;
                case 2: tekst = "Teisipäev"; break;
                case 3: tekst = "Kolmapäev"; break;
                case 4: tekst = "Neljapäev"; break;
                case 5: tekst = "Reede"; break;
                case 6: tekst = "Laupäev"; break;
                case 7: tekst = "Pühapäev"; break;

                default:
                    tekst = "Tundmatu";
                    break;
            }
            return tekst;
        }

        public static string Pinginaabrid(string a, string b)
        {
            string vastus;

            if (a.ToLower() == "maria" && b.ToLower() == "jevgeni" || a.ToLower() == "jevgeni" && b.ToLower() == "maria")
            {
                vastus = "Need inimesed on pinginaabrid!";
            }
            else
            {
                vastus = "Need inimesed ei ole pinginaabrid1";
            }
            return vastus;
        }

        public static float PorandaPindala(float a, float b)
        {

        }
    }
}
