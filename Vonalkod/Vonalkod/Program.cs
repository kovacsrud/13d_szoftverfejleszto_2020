using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vonalkod
{
    class Program
    {
        static bool VonalkodEllenorzes(string vonalkod)
        {
            bool joVonalkod = false;
            int osszeg = 0;

            char[] vonalkodTomb = vonalkod.ToCharArray();

            for (int i = 0; i < vonalkodTomb.Length-1; i++)
            {
                //minden páratlan helyen álló számjegyet 3-al
                //minden páros helyen állót 1-el kell szorozni
                //6291041500213
                if ((i+1)%2==0)
                {
                    osszeg += (int)Char.GetNumericValue(vonalkodTomb[i])*3;
                } else
                {
                    osszeg += (int)Char.GetNumericValue(vonalkodTomb[i]);
                }
                


            }
            
            var ellenorzojegy = 10 - (osszeg % 10);

            if (ellenorzojegy==(int)Char.GetNumericValue(vonalkodTomb[vonalkodTomb.Length-1]))
            {
                joVonalkod = true;
            }



            return joVonalkod;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(VonalkodEllenorzes("6291041500213"));

            Console.ReadKey();
        }
    }
}
