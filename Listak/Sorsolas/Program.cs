using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorsolas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> szamgomb = new List<int>();
            List<int> kivalasztott = new List<int>();
            int darab = 5;
            int feltolt = 90;

            for (int i = 0; i < feltolt; i++)
            {
                szamgomb.Add(i + 1);
            }

            //foreach (var i in szamgomb)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 0; i < darab; i++)
            {
                Console.WriteLine($"Számgomb elemszám:{szamgomb.Count}");
                var elemindex = rand.Next(0, szamgomb.Count);
                kivalasztott.Add(szamgomb[elemindex]);
                szamgomb.RemoveAt(elemindex);
                
            }

            kivalasztott.Sort();

            foreach (var i in kivalasztott)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            foreach (var i in szamgomb)
            {
                Console.Write($"{i} ");
            }
            //Tegyük vissza a kivett elemeket a szamgomb listába!

            Console.ReadKey();
        }
    }
}
