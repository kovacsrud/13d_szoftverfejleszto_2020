using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {
            //elöltesztelő,hátultesztelő,növekményes(előírt lépésszámú)

            //elöltesztelő,while ciklus

            int lepes = 100;

            while (lepes>=0)
            {
                //ez a ciklusmag
                Console.WriteLine(lepes);
                lepes--;
            }

            Console.WriteLine("A ciklus utáni utasítás");

            lepes = 5;

            //hátultesztelő ciklus do while

            do
            {
                //ciklusmag
                Console.WriteLine(lepes);
                lepes++;

            } while (lepes<=10);



            Console.ReadKey();
        }
    }
}
