using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Teglalap> teglalapok = new List<Teglalap>();
            var elemszam = rand.Next(50, 100 + 1);

            for (int i = 0; i < elemszam; i++)
            {
                teglalapok.Add(new Teglalap(rand.Next(1, 20), rand.Next(1, 30)));
            }

            Console.WriteLine($"A lista elemszáma:{teglalapok.Count}");

            foreach (var i in teglalapok)
            {
                Console.WriteLine($"A:{i.Aoldal},B:{i.Boldal},Kerület:{i.Kerulet()},Terület:{i.Terulet()}");
            }

            //Mennyi a kerületek átlaga?
            Console.ReadKey();
        }
    }
}
