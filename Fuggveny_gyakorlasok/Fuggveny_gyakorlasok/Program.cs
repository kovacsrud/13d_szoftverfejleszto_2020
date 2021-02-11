using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggveny_gyakorlasok
{
    class Program
    {
        //Ide is jöhet a függvény def

        static double Km2Mph(double km)
        {
            var mph = km / 1.6;
            return mph;
        }

        static int KarSzam(string szoveg,char kar)
        {
            var darab = 0;

            for (int i = 0; i < szoveg.Length; i++)
            {
                if (Char.ToLower(szoveg[i])==Char.ToLower(kar))
                {
                    darab++;
                }
            }
            return darab;
        }

        static string Nagykezd(string szoveg)
        {
            char[] szovegtomb = szoveg.ToCharArray();

            szovegtomb[0] = Char.ToUpper(szovegtomb[0]);

            for (int i = 1; i < szovegtomb.Length; i++)
            {
                szovegtomb[i] = Char.ToLower(szovegtomb[i]);
            }

            return new string(szovegtomb);

        }

        static string Nagykezd2(string szoveg)
        {
            char[] szovegtomb = szoveg.ToCharArray();

            
            for (int i = 0; i < szovegtomb.Length; i++)
            {
                if (i==0)
                {
                    szovegtomb[i] = Char.ToUpper(szovegtomb[i]);
                } else
                {
                    szovegtomb[i] = Char.ToLower(szovegtomb[i]);
                }

                
            }

            return new string(szovegtomb);

        }

        static int KarOsszeg(string szoveg)
        {
            int osszeg = 0;
            char[] szovegtomb = szoveg.ToCharArray();

            for (int i = 0; i < szovegtomb.Length ; i++)
            {
                if (Char.IsDigit(szovegtomb[i]))
                {
                    osszeg += (int)Char.GetNumericValue(szovegtomb[i]);
                }
            }

            return osszeg;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"122 km:{Km2Mph(122)} mérföld");
            var szoveg = "VAlAaaami szöveg";
            var kar = 'x';
            Console.WriteLine($"{kar} darabszáma a {szoveg} szövegben:{KarSzam(szoveg,kar)}");

            Console.WriteLine($"{Nagykezd("kovács")}");
            Console.WriteLine($"{Nagykezd2("kovács")}");
            Console.WriteLine(KarOsszeg("zzr1200225664688"));


            Console.ReadKey();
        }
        //Ide jöhet a függvény def
    }
}
