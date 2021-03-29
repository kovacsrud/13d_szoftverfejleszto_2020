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

            Console.ReadKey();
        }
    }
}
