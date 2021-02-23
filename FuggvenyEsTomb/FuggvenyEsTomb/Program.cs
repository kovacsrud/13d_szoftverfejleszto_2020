using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuggvenyEsTomb
{
    class Program
    {
        static int[] TombKeszit(int also,int felso,int db)
        {
            Random rand = new Random();
            int[] tomb = new int[db];

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rand.Next(also, felso);
            }

            return tomb;
        }

        static int[] TombKeszit(int also,int felso,int db,Random rand)
        {
            int[] tomb = new int[db];

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rand.Next(also, felso);
            }

            return tomb;
        }



        static void Main(string[] args)
        {

            Random rand = new Random();

            int[] t1 = TombKeszit(-10, 10, 5,rand);
            int[] t2 = TombKeszit(-10, 50, 10);
            int[] t3 = TombKeszit(100, 200, 15,rand);
            TombLista(t1);
            TombLista(t2);
            TombLista(t3);
           

            Console.ReadKey();
        }

        private static void TombLista(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]+" ");
                
            }
            Console.WriteLine();
        }
    }
}
