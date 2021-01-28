using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElagazasEsTomb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot:");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam>0)
            {//kódblokk, az itt létrehozott változók lokális
             //változók, és csak ebben a kódblokkban érhetők el   
                Console.WriteLine("Pozitív");
            } else if (szam<0)
            {
                Console.WriteLine("Negatív");
            } else
            {
                Console.WriteLine("Nulla");
            }

            Console.ReadKey();
        }
    }
}
