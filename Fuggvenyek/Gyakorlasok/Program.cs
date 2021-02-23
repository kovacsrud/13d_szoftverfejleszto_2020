using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlasok
{
    class Program
    {
        static double Negyzet(double szam)
        {
            var negyzet = szam * szam;
            return negyzet;
        }
        static void Main(string[] args)
        {
            //Írjon egy függvényt, amely a kapott
            //szám négyzetét adja vissza!

            Console.WriteLine(Negyzet(9));
            Console.WriteLine(Negyzet(3.6678));
            Console.ReadKey();
        }
    }
}
