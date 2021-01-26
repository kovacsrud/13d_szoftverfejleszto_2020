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



            Console.ReadKey();
        }
    }
}
