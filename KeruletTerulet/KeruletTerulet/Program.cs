using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeruletTerulet
{
    class Program
    {

        static double TeglalapKerulet(double a,double b)
        {
            return (a + b) * 2;
        }

        static double TeglalapTerulet(double a,double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.Write("Add meg a téglalap A oldalát!:");
            double aoldal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a téglalap B oldalát!:");
            var boldal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A téglalap kerülete:{TeglalapKerulet(aoldal,boldal)}");

            Console.WriteLine($"A téglalap területe:{TeglalapTerulet(aoldal,boldal)}");



            Console.ReadKey();
        }
    }
}
