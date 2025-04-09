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

        public static double Korrutamine(double a, double b)
        {
            double vastus = a * b;
            return vastus;
        }

        public static double Hinnasoodustus(double a)
        {
            double vastus = a * 0.7;
            return vastus;
        }

        public static string Temperatuur(int a)
        {
            string vastus;
            if (a > 18)
            {
                vastus = "Temperatuur "+a+" on soovitav toasoojus talvel";
            }
            else
            {
                vastus = "Temperatuur ei ole soovitav talvel";
            }
            return vastus;
        }

        public static string Pikkus(int a)
        {
            string vastus;
            if (a < 160)
            {
                vastus = "Pikkus " + a + " cm, te olete lühikest kasvu";
            }
            else if (a >= 160 || a < 175)
            {
                vastus = "Pikkus " + a + " cm, te olete keskmist kasvu";
            }
            else
            {
                vastus = "Pikkus " + a + " cm, te olete pikka kasvu";
            }
            return vastus;
        }

        public static string PikkusSugu(int pikkus, string sugu)
        {
            string vastus;
            if (sugu.ToLower() == "mees") 
            {
                if (pikkus < 160)
                {
                    vastus = "Pikkus " + pikkus + " cm, te olete lühikest kasvu meeste jaoks";
                }
                else if (pikkus >= 160 || pikkus < 175)
                {
                    vastus = "Pikkus " + pikkus + " cm, te olete keskmist kasvu meeste jaoks";
                }
                else
                {
                    vastus = "Pikkus " + pikkus + " cm, te olete pikka kasvu meeste jaoks";
                }
            }
            else if (sugu.ToLower() == "naine")
            {
                if (pikkus < 150)
                {
                    vastus = "Pikkus " + pikkus + " cm, te olete lühikest kasvu naiste jaoks";
                }
                else if (pikkus >= 160 || pikkus < 170)
                {
                    vastus = "Pikkus " + pikkus + " cm, te olete keskmist kasvu naiste jaoks";
                }
                else
                {
                    vastus = "Pikkus " + pikkus + " cm, te olete pikka kasvu naiste jaoks";
                }
            }
            else
            {
                vastus = "Tundmatu sugu!";
            }

            return vastus;
        }
        public static string Pood(string vastus1, string vastus2, string vastus3)
        {
            string vastus;
            if (vastus1.ToLower() = "jah")
            {
                float hind1 = ;
            }
            else if (a >= 160 || a < 175)
            {
                vastus = "Pikkus " + a + " cm, te olete keskmist kasvu";
            }
            else
            {
                vastus = "Pikkus " + a + " cm, te olete pikka kasvu";
            }
            return vastus;
        }

    }
}
