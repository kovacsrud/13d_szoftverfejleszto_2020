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
            Console.WriteLine($@"Ennyi dísz maradt készleten:
            Fenyőfa: {adottNap.FenyofaKesz-adottNap.FenyofaEladott}
            Angyalka: {adottNap.AngyalkaKesz-adottNap.AngyalkaEladott}
            Harang: {adottNap.HarangKesz-adottNap.HarangEladott}    
            ");

            List<int> osszdarabok = new List<int>();
            List<string> disznevek = new List<string>();

            var osszFenyo = Math.Abs(napimunkak.Sum(x => x.FenyofaEladott));
            osszdarabok.Add(osszFenyo);
            disznevek.Add("fenyőfa");
            var osszHarang = Math.Abs(napimunkak.Sum(x=>x.HarangEladott));
            osszdarabok.Add(osszHarang);
            disznevek.Add("harang");
            var osszAngyal = Math.Abs(napimunkak.Sum(x => x.AngyalkaEladott));
            osszdarabok.Add(osszAngyal);
            disznevek.Add("angyal");

            var maxEladott = osszdarabok.Max();

            for (int i = 0; i < osszdarabok.Count; i++)
            {
                if (osszdarabok[i]==maxEladott)
                {
                    Console.WriteLine($"Dísz:{disznevek[i]}," +
                        $"eladott darab:{osszdarabok[i]}");
                }
            }

            try
            {
                FileStream fajl = new FileStream("bevetel.txt",FileMode.Create);
                StreamWriter wr = new StreamWriter(fajl, Encoding.Default);
                int szamlalo = 0;
                foreach (var i in napimunkak)
                {
                    if (i.NapiBevetel()>=10000)
                    {
                        wr.WriteLine($"{i.Nap}:{i.NapiBevetel()}");
                        szamlalo++;
                    }
                }
                wr.WriteLine($"{szamlalo} napon volt legalább 10000Ft a bevétel");
                wr.Close();
                Console.WriteLine("Fájba írás kész");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            
            



            Console.ReadKey();
        }
    }
}
