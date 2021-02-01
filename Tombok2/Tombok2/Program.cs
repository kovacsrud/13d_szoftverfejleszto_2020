using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[100];
            Random rand = new Random();

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(-100, 100 + 1);
            }

            int osszeg = 0;
            int min = szamok[0];
            int max = szamok[0];
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
                //osszeg=osszeg+szamok[i];
                if (szamok[i]>max)
                {
                    max = szamok[i];
                }
                if (szamok[i]<min)
                {
                    min = szamok[i];
                }
            }

            Console.WriteLine($"Összeg:{osszeg},Min:{min},Max:{max}");
            Console.WriteLine($"Átlag:{osszeg/szamok.Length}");

            Console.WriteLine($"Összeg:{szamok.Sum()}");
            Console.WriteLine($"Átlag:{szamok.Average()}");
            Console.WriteLine($"Min:{szamok.Min()}");
            Console.WriteLine($"Max:{szamok.Max()}");

            //prog tételek: összeg,átlag,min,max

            //keresés a tömbben
            int keresett = 29;
            bool megvan = false;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]==keresett)
                {
                    megvan = true;
                    break;
                }
            }

            if (megvan)
            {
                Console.WriteLine("Benne van!");
            } else
            {
                Console.WriteLine("Nincs benne");
            }

            if (szamok.Contains(keresett))
            {
                Console.WriteLine("Benne van!");
            } else
            {
                Console.WriteLine("Nincs benne");
            }

            //megszámlálás, hány pozitív elem van a tömbben?
            int db = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]>0)
                {
                    db++;
                }
            }

            Console.WriteLine($"Pozitív számok:{db}");

            Console.ReadKey();
        }
    }
}
