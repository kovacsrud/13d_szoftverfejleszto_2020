using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Program
    {
        static void Main(string[] args)
        {
            //A lista elemszáma nem kötött mint a tömb elemszáma
            
            List<int> szamok = new List<int>();

            //Elem beillesztése a listára
            szamok.Add(126);
            szamok.Add(45);
            szamok.Add(557);
            szamok.Add(7789);

            //Lista elemszámának meghatározása
            Console.WriteLine($"Lista elemszáma:{szamok.Count}");

            //hozzáférés a lista elemeihez
            Console.WriteLine(szamok.ElementAt(1));
            Console.WriteLine(szamok[1]);
            Console.WriteLine(szamok.First());
            Console.WriteLine(szamok.Last());

            //A tömb, vagy lista elemeinek a módosítása csak
            //for ciklusban lehetséges
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.WriteLine($"{i}.elem:{szamok[i]}");
            }

            //Foreach ciklusban nem lehet módosítani a tömböt/listát
            foreach (var i in szamok)
            {
                Console.WriteLine(i);
            }

            //összeg, átlag...
            Console.WriteLine($"Összeg:{szamok.Sum()}");
            Console.WriteLine($"Átlag:{szamok.Average()}");
            Console.WriteLine($"Min:{szamok.Min()}");
            Console.WriteLine($"Összeg:{szamok.Max()}");

            //Elem törlése a listáról
            szamok.RemoveAt(3);

            szamok.Remove(45);
                        
            List<int> szamok2 = new List<int>();
            szamok2.Add(233);
            szamok2.Add(411);
            szamok2.Add(39);
            szamok2.Add(411);

            szamok.AddRange(szamok2);

            foreach (var i in szamok)
            {
                Console.WriteLine(i);
            }

            if (szamok2.Contains(234))
            {
                Console.WriteLine("Benne van!");
            } else
            {
                Console.WriteLine("Nincs benne!");
            }

            
            

            Console.ReadKey();
        }
    }
}
