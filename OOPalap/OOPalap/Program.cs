using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPalap
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember geza = new Ember("Géza",1999,178,"Orosháza");
            //geza.SetNev("Géza");

            geza.Koszon();

            Console.WriteLine(geza.GetNev());
            

            Ember ubul = new Ember("Ubul",2001,182,"Szeged");
            //ubul.SetNev("Ub");

            ubul.Koszon();

            Ember gerzson = new Ember();
            
            gerzson.Koszon();
            //----------------------------------

            UjEmber elek = new UjEmber();
            elek.Nev = "Elek";
            elek.SzuletesiEv = 2001;
            elek.Magassag = 189;
            elek.Lakhely = "Makó";

            UjEmber zeno = new UjEmber 
            {
                Nev="Zénó",
                SzuletesiEv=1998,
                Lakhely="Orosháza",
                Magassag=245
            };

            Console.WriteLine($"{zeno.Nev},{zeno.Magassag}");

            UjEmber zoltan = new UjEmber("Zoltán",1987,176,"Gyula");
            Console.WriteLine($"{zoltan.Nev},{zoltan.Magassag}");

                       
            
            Console.ReadKey();
        }
    }
}
