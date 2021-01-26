using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzol_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam1;
            szam1 = 112;

            int szam2 = 233;

            int szam3 = szam1 + szam2;

            szam1 = 2044;

            long nagyszam = 1212343534545;
            

            Console.WriteLine("C# kezdés");

            //Variációk kiíratásra- egy soros komment
            Console.WriteLine($"Szám1:{szam1},szám2:{szam2},szám3:{szam3}");
            Console.WriteLine("{1},{0}", szam1, szam2);

            /* Több
              soros
              komment */
            Console.WriteLine($"Előjeles egész:{Int16.MinValue},{Int16.MaxValue}");
            Console.WriteLine($"Előjeles egész:{Int32.MinValue},{Int32.MaxValue}");
            Console.WriteLine($"Előjeles egész:{Int64.MinValue},{Int64.MaxValue}");

            Console.WriteLine($"Előjel nélkül:{UInt16.MinValue},{UInt16.MaxValue}");
            Console.WriteLine($"Előjel nélkül:{UInt32.MinValue},{UInt32.MaxValue}");
            Console.WriteLine($"Előjel nélkül:{UInt64.MinValue},{UInt64.MaxValue}");

            //8 bites pozitív érték
            byte bajt = 123;

            //lebegőpontos számok
            float nemegesz1 = 123.0123456789012345678901234567890123456789f;
            double nemegesz2 = 123.0123456789012345678901234567890123456789;
            decimal nemegesz3 = 123.0123456789012345678901234567890123456789m;

            Console.WriteLine($"{nemegesz1}");
            Console.WriteLine($"{nemegesz2}");
            Console.WriteLine($"{nemegesz3}");

            double kiirando = 123.123;
            //kiíratás két tizedessel
            Console.WriteLine($"{kiirando:0.00}");

            //kiíratás két tizedessel, ha a tizedes értéke 0, akkor nem jelenik meg
            Console.WriteLine($"{kiirando:0.##}");
            //karakteres típus, egyetlen karakter tárolására
            char betu = 'b';

            //szöveges típus
            string szoveg = "Valami szöveg";

            //indexelhető
            Console.WriteLine(szoveg[4]);

            //logikai típus
            bool logikai = false;

            Console.ReadKey();
        }
    }
}
