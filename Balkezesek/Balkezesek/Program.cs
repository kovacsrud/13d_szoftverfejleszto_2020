using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dobo> dobok = new List<Dobo>();
            try
            {
                var sorok = File.ReadAllLines("balkezesek.csv",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    dobok.Add(new Dobo(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"{dobok.Count} adatsor található");

            var oktober99 = dobok.FindAll(x=>x.UtolsoEv==1999 && x.UtolsoHonap==10);

            foreach (var i in oktober99)
            {
                Console.WriteLine($"{i.Nev},{(i.Magassag*2,54):0.0}");
            }

            Console.Write("Adjon meg egy évet:");
            var evszam = Convert.ToInt32(Console.ReadLine());
            while (evszam>1999 || evszam<1990)
            {
                Console.Write("Hibás évszám!Adja meg újra:");
                evszam = Convert.ToInt32(Console.ReadLine());
            }

            var atlagsuly = dobok.FindAll(x=>x.ElsoEv>=evszam && x.UtolsoEv<=evszam).Average(x=>x.Suly);

            Console.WriteLine($"A dobók átlagsúlya:{atlagsuly:0.00}");

            var doboStat = dobok.ToLookup(x=>x.ElsoEv).OrderBy(x=>x.Key);

            foreach (var i in doboStat)
            {
                Console.WriteLine($"{i.Key},{i.Count()}");
            }

            var doboStat2 = dobok.ToLookup(x=>new {x.ElsoEv,x.UtolsoEv}).OrderBy(x=>x.Key.ElsoEv).ThenBy(x=>x.Key.UtolsoEv);

            foreach (var i in doboStat2)
            {
                Console.WriteLine($"{i.Key.ElsoEv},{i.Key.UtolsoEv},{i.Average(x=>x.Magassag):0.0}");
            }

            Console.ReadKey();
        }
    }
}
