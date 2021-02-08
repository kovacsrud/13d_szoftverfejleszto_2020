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
        static void Kiir(string sz1,string sz2)
        {
            Console.WriteLine($"{sz1},{sz2}");
        }

        static void Main(string[] args)
        {
            Kiir();
            Kiir("Csodás hétfő reggel");
            Kiir("C#", "programozás");
            
          


            Console.ReadKey();
        }


    }
}
