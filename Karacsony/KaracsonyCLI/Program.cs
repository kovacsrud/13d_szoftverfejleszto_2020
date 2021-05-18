using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaracsonyCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> napimunkak = new List<NapiMunka>();

            try
            {
                var sorok = File.ReadAllLines("diszek.txt",Encoding.Default);
                for (int i = 0; i < sorok.Length; i++)
                {
                    napimunkak.Add(new NapiMunka(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Elemszám:{napimunkak.Count}");

            var osszesDisz = napimunkak.Sum(x => x.AngyalkaKesz) +
                napimunkak.Sum(x => x.FenyofaKesz) +
                napimunkak.Sum(x=>x.HarangKesz);

            Console.WriteLine($"Az összes dísz száma:{osszesDisz}");

            if (napimunkak.Any(x=>x.AngyalkaKesz==0 && x.FenyofaKesz==0 && x.HarangKesz==0))
            {
                Console.WriteLine("Volt ilyen nap");
            } else
            {
                Console.WriteLine("Nem volt ilyen nap");
            }

            Console.Write("Adj meg egy számot 1 és 40 között:");
            var szam = Convert.ToInt32(Console.ReadLine());
            while (szam<1 || szam>40)
            {
                Console.Write("Rossz! Add meg újra!");
                szam = Convert.ToInt32(Console.ReadLine());
            }
            var adottNap = napimunkak.Find(x=>x.Nap==szam);




            Console.ReadKey();
        }
    }
}
