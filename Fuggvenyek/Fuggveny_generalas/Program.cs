﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggveny_generalas
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] t1 = { 12, 34, 56, 778, 999 };
            int[] t2 = { 34, 556, 665, 123, 554, 22223, 778, 53 };
            int[] t3 = { 121, 344, 565, 78, 199, 561 };
            int[] t4 = { 869, 445, 129, 376, 886, 912, 1024 };

            TombList(t1);
            TombList(t2);
            TombList(t3);
            TombList(t4);

            Console.ReadKey();
        }

        private static void TombList(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
