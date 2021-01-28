using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tömb deklarálása
            int[] szamok1 = new int[10];
            Console.WriteLine(szamok1[1]);

            //tömb deklarálása az elemek megadásával
            int[] szamok2 = { 1, 9, 34, 46, 19, 6 };
            Console.WriteLine(szamok2[1]);

            string[] nevek = { "Géza", "Elek", "Ubul", "Márta","Judit" };
            char[] karakterek = { 'a', 'q', 'z', 'F' };

            Console.WriteLine(nevek[2]);
            Console.WriteLine(karakterek[3]);

            Console.WriteLine($"Szamok1 elemszáma:{szamok1.Length}");
            Console.WriteLine($"Szamok2 elemszáma:{szamok2.Length}");

            for (int i = 0; i < szamok2.Length; i++)
            {
                Console.Write(szamok2[i]+" ");
            }


            Console.ReadKey();
        }
    }
}
