using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErtekEsRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;

            Console.WriteLine($"{a},{b}");
            
            a = 25;

            Console.WriteLine($"{a},{b}");

            int[] t1 = { 10, 20, 30, 40, 50 };
            int[] t2 = t1;

            Console.WriteLine($"{t1[0]},{t2[0]}");

            t2[0] = 35;
            //t1[0]   ?
            Console.WriteLine($"{t1[0]},{t2[0]}");
            //Mi történt?

            //Érték típusú változók
            //-a stack memóriában találhatóak

            //Referencia típusú változók
            //a stack memóriába csak egy referencia(mutató)
            //kerül, amely megadja, hogy az változó hol
            //található a heap memóriában

            Console.ReadKey();
        }
    }
}
