using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPalap
{
    public class Ember
    {
        private string nev;
        private int szuletesiev;
        private int magassag;
        private string lakhely;

        public Ember(string nev,int szuletesiev,int magassag,string lakhely)
        {
            this.nev = nev;
            this.szuletesiev=szuletesiev;
            this.magassag=magassag;
            this.lakhely = lakhely;
        }

        public Ember()
        {
            this.nev = "átlagember";
            this.szuletesiev = 1980;
            this.magassag = 170;
            this.lakhely = "város";
        }

        public void Koszon()
        {            
            Console.WriteLine($"Hello, {nev} vagyok,lakhelyem {lakhely}");
        }

        public void SetNev(string nev)
        {
            if (nev.Length>=3)
            {
                this.nev = nev;
            } else
            {
                this.nev = "default";
            }
        }

        public string GetNev()
        {
            return nev;
        }

    }
}
