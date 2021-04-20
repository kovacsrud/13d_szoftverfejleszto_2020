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

            Console.ReadKey();
        }
    }
}
