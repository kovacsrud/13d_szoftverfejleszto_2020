using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggvenyek
{
    class Program
    {
        //Overloading, függvény túlterhelés
        /// <summary>
        /// A legegyszerűbb kiíró függvény
        /// </summary>
        static void Kiir()
        {
            Console.WriteLine("Függvény, első verzió");
        }

        /// <summary>
        /// Paraméterben várja a kiírandó szöveget
        /// </summary>
        /// <param name="szoveg"></param>
        static void Kiir(string szoveg)
        {
            Console.WriteLine(szoveg);
        }
        /// <summary>
        /// Két paraméterben lehet megadni a kiírandó szöveget
        /// </summary>
        /// <param name="sz1"></param>
        /// <param name="sz2"></param>
        static void Kiir(string sz1, string sz2)
        {
            Console.WriteLine($"{sz1},{sz2}");
        }

        
        static double Osszead(double a,double b=10)
        {
            return a + b;
        }

        static int Szoroz(int a)
        {
            a = a * a;
            return a;
        }
        /// <summary>
        /// Cím szerinti paraméterátadás
        /// </summary>
        /// <param name="a"></param>
        static void Szoroz(ref int a)
        {
            a = a * a;
        }


        

        static void Main(string[] args)
        {
            Kiir();
            Kiir("Csodás hétfő reggel");
            Kiir("C#", "programozás");
            var osszeg = Osszead(10, 30);
            var alaposszeg = Osszead(40);
            var dbosszeg = Osszead(12.567, 45.7789);
            Console.WriteLine(osszeg);
            Console.WriteLine(alaposszeg);
            Console.WriteLine(dbosszeg);
            Console.WriteLine(Osszead(100,10));
            int a = 3;
            //érték szerinti paraméterátadás
            Console.WriteLine(Szoroz(a));
            Console.WriteLine(a);
            //cím szerinti paraméterátadás
            Szoroz(ref a);
            Console.WriteLine(a);






            Console.ReadKey();
        }


    }
}
