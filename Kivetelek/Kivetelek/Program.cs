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
                int b = 12;
                int c = a / b;

                try
                {
                    throw new ArrayTypeMismatchException();
                    
                }
                catch (FormatException ex)
                {

                    Console.WriteLine("Beágyazott catch blokk");
                }

                Console.WriteLine("A művelet eredménye:");
                Console.WriteLine(c);
                //throw new ArithmeticException("Aritmetikai hiba!");
                
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("B értéke nem lehet 0! Adjon meg mást!");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Ennek a blokknak az utasításai mindenféleképp végrehajtódnak");
            }

            Console.WriteLine("A try-catch utáni utasítás");
            

            Console.ReadKey();
        }
    }
}
