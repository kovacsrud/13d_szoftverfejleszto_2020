using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHianyzas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tanulo> tanulok = new List<Tanulo>();

            try
            {
                var sorok = File.ReadAllLines("szeptember.csv",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    tanulok.Add(new Tanulo(sorok[i],';')); ;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Adatok száma:{tanulok.Count}");

            Console.WriteLine($"Az összes hiányzás:{tanulok.Sum(x=>x.MulasztottOrak)} óra");

            Console.Write("Adjon meg egy napot(1-30):");
            var nap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adjon meg egy nevet:");
            var nev = Console.ReadLine();
            var hianyzott = tanulok.Find(x=>x.Nev==nev);

            if (hianyzott==null)
            {
                Console.WriteLine($"{nev} nem hiányzott");
            } else
            {
                Console.WriteLine($"{nev}-nek van hiányzása");
            }

            if (tanulok.Any(x=>x.Nev==nev))
            {                
                Console.WriteLine($"{nev}-nek van hiányzása");
            } else
            {
                Console.WriteLine($"{nev} nem hiányzott");
            }

            Console.ReadKey();
        }
    }
}
