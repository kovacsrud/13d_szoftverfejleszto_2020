using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 120;
                int b = 0;
                int c = a / b;

                Console.WriteLine("A művelet eredménye:");
                Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);                
            }


            Console.WriteLine("A try-catch utáni utasítás");
            

            Console.ReadKey();
        }
    }
}
