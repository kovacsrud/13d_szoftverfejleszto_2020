using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            //inkrementáló utasítás 1-el növeli az értéket
            a++;

            //inkrementáló utasítás 1-el növeli az értéket
            ++a;
            //Console.WriteLine(a);

            int b = a++;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
