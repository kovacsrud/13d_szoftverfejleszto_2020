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




            
            Console.ReadKey();
        }
    }
}
