using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklus_gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kérjünk be 2 számot, és osszuk el őket egymással!
            Console.Write("A:");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B:");
            var b = Convert.ToInt32(Console.ReadLine());
            //Oldjuk meg, hogy a b változó értéke ne lehessen 0!

            while(b==0)
            {
                Console.Write("B nem lehet 0! Újra add meg:");
                try
                {
                    b = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);                    
                }
                
            }

            //típuskényszerítést használunk
            var c = (double)a / b;

            Console.WriteLine($"Az osztás eredménye:{c}");

            Console.ReadKey();
        }
    }
}
