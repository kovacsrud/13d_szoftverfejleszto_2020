using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ember> emberek = new List<Ember>();

            Sportolo sportolo = new Sportolo 
            {
                Nev="Nagy Elek",
                Magassag=178,
                Suly=79,
                SzuletesiEv=1996,
                Sportag="atlétika"
            };
            sportolo.Mozog();
            Console.WriteLine(sportolo.GetEletkor());
            sportolo.Edz();

            Nyugdijas nyugdijas = new Nyugdijas
            {
                Magassag=180,
                Nev="Nagy Áron",
                Suly=89,
                SzakmaNyudgijElott="sofőr",
                SzuletesiEv=1949
            };

            nyugdijas.Alszik();
            Console.WriteLine(nyugdijas.GetEletkor());

            //Készítsenek egy Tanulo osztályt
            //Legyen benne egy Iskola property
            //Legyen Tanul()

            Tanulo tanulo = new Tanulo
            {
                Iskola="Trefort",
                Magassag=169,
                Nev="Kovács Nóra",
                Suly=68,
                SzuletesiEv=1999
            };

            emberek.Add(sportolo);
            emberek.Add(nyugdijas);
            emberek.Add(tanulo);
            

            Console.ReadKey();
        }
    }
}
