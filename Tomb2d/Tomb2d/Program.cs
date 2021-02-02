using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb2d
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[,] szamok = new int[10, 20];

            Console.WriteLine(szamok.Length);

            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                for (int j = 0; j < szamok.GetLength(1); j++)
                {
                    szamok[i, j] = rand.Next(10, 100);
                    Console.Write(szamok[i,j]+" ");
                }
                Console.WriteLine();
            }

            int osszeg = 0;
            int min = szamok[0, 0];
            int max = szamok[0, 0];

            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                
                for (int j = 0; j < szamok.GetLength(1); j++)
                {
                    osszeg += szamok[i, j];
                    if (szamok[i,j]>max)
                    {
                        max = szamok[i, j];
                    }
                    if (szamok[i,j]<min)
                    {
                        min = szamok[i, j];
                    }
                }
            }

           
            Console.WriteLine($"Összeg:{osszeg}");
            Console.WriteLine($"Min:{min}");
            Console.WriteLine($"Max:{max}");
            Console.ReadKey();
        }
    }
}
