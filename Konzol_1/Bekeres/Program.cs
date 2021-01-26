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

            Console.WriteLine($"Szám1:{szam1}");

            Console.ReadKey();
        }
    }
}
