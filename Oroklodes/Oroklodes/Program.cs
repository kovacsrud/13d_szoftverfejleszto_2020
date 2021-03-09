using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Program
    {
        static void Main(string[] args)
        {

            Allat allat = new Allat(6, "kutya", 12);
            allat.Mozog();
            allat.Iszik();
            allat.Eszik();

            Console.WriteLine(allat.ToString());

            Kutya kutya = new Kutya(6, "kutya", 35, "komondor", "fehér"); 
           
            kutya.Iszik();
            kutya.Eszik();
            kutya.Ugat();
            Console.WriteLine(kutya.ToString());

            //Készítsen egy Macska nevű osztályt! Az osztályt
            //származtassa le az Allat osztályból! 
            //A macska nevű osztályhoz adja hozzá a 
            //Fajta, Szin, Szorhossz(rövid/hosszú) propertyket
            //Készítsen egy Nyavog() metódust
            //Írja felül a ToString() metódust, ami az 
            //osztály adatait jelenítse meg!
            Macska macska = new Macska(2, "macska", 2, "sziámi", "fehér", true);
            Console.WriteLine(macska.ToString());
            

            Console.ReadKey();
        }
    }
}
