using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            //tippek tárolása->tömb vagy lista
            //nyerőszámok tárolása->tömb vagy lista
            //nyerőszámok száma: hány számmal játszunk?
            //hány számból húzunk ?
            //találatok száma

            //Annak a bekérése hogy hány számmal játszunk
            //és hogy mennyiből húzunk
            Console.Write("Hány számmal játszunk?:");
            int hanySzam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mennyiből húzunk?");
            int mennyiSzam = Convert.ToInt32(Console.ReadLine());


            Console.ReadKey();
        }
    }
}
