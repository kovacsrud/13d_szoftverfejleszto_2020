using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idojaras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IdojarasAdat> idoAdatok = new List<IdojarasAdat>();
            try
            {
                var sorok = File.ReadAllLines("idojaras.csv",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    idoAdatok.Add(new IdojarasAdat(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Adatsorok száma:{idoAdatok.Count}");

            //Legkisebb év:min
            //legnagyobb év:max
            //
            var minEv = idoAdatok.Min(x => x.Ev);
            var maxEv = idoAdatok.Max(x => x.Ev);

            var elsoNap = idoAdatok.OrderBy(x=>x.Ev).ThenBy(x=>x.Honap).ThenBy(x=>x.Nap).ThenBy(x=>x.Ora).First();
            var utolsoNap = idoAdatok.OrderBy(x => x.Ev).ThenBy(x => x.Honap).ThenBy(x => x.Nap).ThenBy(x => x.Ora).Last();

            Console.WriteLine($@"Az időszak:
            Első nap:{elsoNap.Ev}.{elsoNap.Honap}.{elsoNap.Nap} {elsoNap.Ora}
            Utolsó nap:{utolsoNap.Ev}.{utolsoNap.Honap}.{utolsoNap.Nap} {utolsoNap.Ora}
            ");

            //Mennyi volt 2006-ban az átlaghőmérséklet?
            var atlagHo2006 = idoAdatok.FindAll(x=>x.Ev==2006).Average(x=>x.Homerseklet);

            Console.WriteLine($"2006 átlaghőmérséklete:{atlagHo2006}");


            //Mennyi volt az átlaghőmérséklet 2010-ben havonta?

            var ev2010 = idoAdatok.FindAll(x=>x.Ev==2010);

            var stat2010 = ev2010.ToLookup(x=>x.Honap).OrderBy(x=>x.Key);

            foreach (var i in stat2010)
            {
                Console.WriteLine($"Hónap:{i.Key} - Átlag hőmérséklet:{i.Average(x=>x.Homerseklet):0.00}");
            }


            //Mennyi volt az átlaghőmérséklet 2010-ben naponta?
            var stat2010nap = ev2010.ToLookup(x =>new {x.Honap,x.Nap}).OrderBy(x => x.Key.Honap).ThenBy(x=>x.Key.Nap);

            foreach (var i in stat2010nap)
            {
                Console.WriteLine($"{i.Key.Honap}.{i.Key.Nap} - Átlag:{i.Average(x=>x.Homerseklet):0.0},Min:{i.Min(x=>x.Homerseklet):0.0},Max:{i.Max(x=>x.Homerseklet):0.0}");
            }

            //Határozzuk meg, az egyes évek átlaghőmérsékletét

            var evekAtlagho = idoAdatok.GroupBy(x=>x.Ev).OrderBy(x=>x.Key);

            foreach (var i in evekAtlagho)
            {
                Console.WriteLine($"{i.Key} - {i.Average(x=>x.Homerseklet)}");
            }

            //Határozzuk meg, az egyes évek hónapjainak átlaghőmérsékletét

            var evekHonapokAtlagho = idoAdatok.GroupBy(x =>new { x.Ev,x.Honap }).OrderBy(x => x.Key.Ev).ThenBy(x=>x.Key.Honap);

            foreach (var i in evekHonapokAtlagho)
            {
                Console.WriteLine($"{i.Key.Ev}.{i.Key.Honap} - {i.Average(x => x.Homerseklet)}");
            }

            try
            {
                FileStream fajl = new FileStream("atlagho_statisztika.txt",FileMode.Create);
                StreamWriter wr = new StreamWriter(fajl,Encoding.Default);

                foreach (var i in evekHonapokAtlagho)
                {
                    wr.WriteLine($"{i.Key.Ev};{i.Key.Honap};{i.Average(x=>x.Homerseklet)}");
                }

                wr.Close();
                Console.WriteLine("Kiírás kész");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);             
            }


            //Készítsen összesítést, amely évre,hónapra, napra meghatározza az átlagos
            //szélsebességet, majd az eredményt fájlba írja!

            Console.ReadKey();
        }
    }
}
