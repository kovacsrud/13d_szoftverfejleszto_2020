using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snooker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();

            try
            {
                var sorok = File.ReadAllLines("snooker.txt",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    versenyzok.Add(new Versenyzo(sorok[i], ';'));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"A világranglistán {versenyzok.Count} versenyző szerepel");

            var atlagNyeremeny = versenyzok.Average(x=>x.Nyeremeny);
            Console.WriteLine($"Az átlagos nyeremény:{atlagNyeremeny:0.00} font");

            var kinaiak = versenyzok.FindAll(x=>x.Orszag=="Kína");

            var legjobbKinai = kinaiak.Find(x=>x.Nyeremeny==kinaiak.Max(y=>y.Nyeremeny));

            Console.WriteLine($@"A legtöbbet kereső kínai:
            Név:{legjobbKinai.Nev}
            Helyezés:{legjobbKinai.Helyezes}
            Nyeremény:{legjobbKinai.Nyeremeny*380:n} Ft");

            var norveg = versenyzok.Find(x=>x.Orszag=="Norvégia");

            if (norveg==null)
            {
                Console.WriteLine("Nincs norvég versenyző");
            }else
            {
                Console.WriteLine("Van norvég versenyző");
            }

            var statisztika = versenyzok.ToLookup(x => x.Orszag).Where(x=>x.Count()>4).OrderByDescending(x=>x.Count());
            foreach (var i in statisztika)
            {
                 Console.WriteLine($"{i.Key} - {i.Count()}");
                
            }

            //Mennyi az átlagnyeremény országonként?
            //foreach (var i in statisztika)
            //{
            //    Console.WriteLine($"{i.Key},{i.Average(x=>x.Nyeremeny)}");
            //}

            //Mennyi a legmagasabb nyeremény az adott országban?

            Console.ReadKey();
        }
    }
}
