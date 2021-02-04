using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> szamok = new List<int>();
            //Töltsük fel a listát véletlen számokkal
            //1 és 1000 között
            //A lista elemszámát is véletlen számmal
            //határozzuk meg (10 és 50 között)
            //Írassuk ki a lista hosszát, min,max,átlag,összeg
            var elemszam = rand.Next(10, 50+1);

            for (int i = 0; i < elemszam; i++)
            {
                szamok.Add(rand.Next(1, 1000 + 1));
                Console.Write(szamok[i]+" ");
            }
            Console.WriteLine("");
            Console.WriteLine($"Darab:{szamok.Count}");
            Console.WriteLine($"Min:{szamok.Min()}");
            Console.WriteLine($"Max:{szamok.Max()}");
            Console.WriteLine($"Átlag:{szamok.Average()}");
            Console.WriteLine($"Összeg:{szamok.Sum()}");

            Console.ReadKey();
        }
    }
}
