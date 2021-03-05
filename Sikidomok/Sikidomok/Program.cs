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
            List<Kor> korok = new List<Kor>();

            var elemszam = rand.Next(50, 100 + 1);

            for (int i = 0; i < elemszam; i++)
            {
                teglalapok.Add(new Teglalap(rand.Next(1, 20), rand.Next(1, 30)));
                korok.Add(new Kor { Sugar = rand.Next(1, 50) });
            }

            Console.WriteLine($"A lista elemszáma:{teglalapok.Count}");
            Console.WriteLine($"A körök listájának elemszáma:{korok.Count}");


            foreach (var i in teglalapok)
            {
                Console.WriteLine($"A:{i.Aoldal},B:{i.Boldal},Kerület:{i.Kerulet()},Terület:{i.Terulet()}");
            }

            //Mennyi a kerületek átlaga?
            int osszeg = 0;

            foreach (var i in teglalapok)
            {
                osszeg += i.Kerulet();
            }

            Console.WriteLine($"A kerületek átlaga:{(double)osszeg/teglalapok.Count}");

            var keruletAtlag = teglalapok.Average(x=>x.Kerulet());

            Console.WriteLine($"A kerületek átlaga:{keruletAtlag}");

            foreach (var i in korok)
            {
                Console.WriteLine($"Sugár:{i.Sugar},Kerület:{i.Kerulet():0.00},Terület:{i.Terulet():0.00}");
            }

            var korKeruletAtlag = korok.Average(x=>x.Kerulet());
            var korTeruletAtlag = korok.Average(x => x.Terulet());

            Console.WriteLine($"Kerületek átlaga:{korKeruletAtlag:0.0}");
            Console.WriteLine($"Területek átlaga:{korTeruletAtlag:0.0}");

            //A legkisebb és a legnagyobb sugár?
            Console.WriteLine($"A legnagyobb sugár:{korok.Max(x=>x.Sugar)}");
            Console.WriteLine($"A legkisebb sugár:{korok.Min(x=>x.Sugar)}");

            //A legkisebb és a legnagyobb terület,kerület
            Console.WriteLine($"A legkisebb terület:{korok.Min(x=>x.Terulet()):0.00}");
            Console.WriteLine($"A legkisebb terület:{korok.Max(x => x.Terulet()):0.00}");

            Console.ReadKey();
        }
    }
}
