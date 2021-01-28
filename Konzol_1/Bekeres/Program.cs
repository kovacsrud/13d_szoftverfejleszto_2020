using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bekeres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot:");
            int szam1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adj meg egy másik számot:");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            //A var használata esetén a fordító mindig a megfelelő
            //típust fogja a változóhoz rendelni
            var szam3 = szam1 + szam2;
            
            Console.WriteLine($"Szám1:{szam1},Szám2:{szam2},Összeg:{szam3}");

            //Két szám szorzása

            //Adott számot emeljünk egy adott hatványra
            //Math.Pow

            int hatvanySzam = Convert.ToInt32(Console.ReadLine());
            int kitevo= Convert.ToInt32(Console.ReadLine());

            var hatvany = Math.Pow(hatvanySzam, kitevo);

            Console.WriteLine(hatvany);

            //kérjük be egy kör sugarát, adjuk meg a kerületét, területét
            Console.Write("Add meg a kör sugarát:");
            var sugar = Convert.ToInt32(Console.ReadLine());
            var kerulet = 2 * sugar * Math.PI;
            var terulet = sugar * sugar * Math.PI;

            Console.WriteLine($"Kerület:{kerulet:0.00},terület:{terulet:0.00}");


            Console.ReadKey();
        }
    }
}
