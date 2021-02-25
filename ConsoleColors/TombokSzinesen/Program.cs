using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombokSzinesen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] szamok = new int[50];

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(-100, 101);
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]>0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(szamok[i] + " ");
                    Console.ResetColor();
                } else if (szamok[i] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(szamok[i] + " ");
                    Console.ResetColor();
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(szamok[i] + " ");
                    Console.ResetColor();
                }
            }


            Console.ReadKey();
        }
    }
}
