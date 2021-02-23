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

        static double KorKerulet(double sugar)
        {
            return 2 * sugar * Math.PI;
        }

        static double KorTerulet(double sugar)
        {
            return sugar * sugar * Math.PI;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("(K)ör vagy (t)églalap számítás?");
            var valasz = Console.ReadKey().KeyChar;
            Console.WriteLine();

          while (Char.ToLower(valasz) == 'k' || Char.ToLower(valasz) == 't')
          {

                       


            if (Char.ToLower(valasz)=='k')
            {
                Console.Write("Add meg a kör sugarát:");
                var sugar = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"A kör kerülete:{KorKerulet(sugar)}");
                Console.WriteLine($"A kör területe:{KorTerulet(sugar)}");
            }
            else if (Char.ToLower(valasz)=='t')
            {
                Console.Write("Add meg a téglalap A oldalát!:");
                double aoldal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Add meg a téglalap B oldalát!:");
                var boldal = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"A téglalap kerülete:{TeglalapKerulet(aoldal, boldal)}");

                Console.WriteLine($"A téglalap területe:{TeglalapTerulet(aoldal, boldal)}");
            } else
            {
                Console.WriteLine("Semmit nem kell számolnom! :)");
            }


                Console.WriteLine("(K)ör vagy (t)églalap számítás?");
                valasz = Console.ReadKey().KeyChar;
                Console.WriteLine();

            }






            Console.ReadKey();
        }
    }
}
