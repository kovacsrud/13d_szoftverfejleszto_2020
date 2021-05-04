using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eucsatlakozas
{
    class Program
    {
        public static Orszaglista orszaglista;

        static void Main(string[] args)
        {
            

            try
            {
                orszaglista = new Orszaglista("EUcsatlakozas.txt",';');
                               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Adatok száma:{orszaglista.Orszagok.Count}");

            var tagok2018 = orszaglista.Orszagok.FindAll(x => x.Csatlakozas.Year <= 2018).Count;
            Console.WriteLine($"Tagok száma 2018-ban:{tagok2018}");

            var csat2007 = orszaglista.Orszagok.FindAll(x => x.Csatlakozas.Year == 2007).Count;
            Console.WriteLine($"2007-ben csatlakozott:{csat2007} ország");

            var magyar = orszaglista.Orszagok.Find(x=>x.Orszagnev=="Magyarország").Csatlakozas;
            Console.WriteLine($"Magyarország csatlakozott:{magyar}");

            if (orszaglista.Orszagok.Any(x=>x.Csatlakozas.Month==5))
            {
                Console.WriteLine("Májusban volt csatlakozás");
            }else
            {
                Console.WriteLine("Májusban nem volt csatlakozás");
            }

            var utoljara = orszaglista.Orszagok.Find(x=>x.Csatlakozas==orszaglista.Orszagok.Max(y=>y.Csatlakozas));
            Console.WriteLine($"Utoljára csatlakozott:{utoljara.Orszagnev}");

            var stat = orszaglista.Orszagok.ToLookup(x=>x.Csatlakozas.Year).OrderByDescending(x=>x.Key);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key}-{i.Count()} ország");
            }


            Console.ReadKey();
        }
    }
}
