using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPalap
{
    public class UjEmber
    {
       

        public string Nev { get;  set; }
        public int SzuletesiEv { get; set; }

        private int magassag;
        public int Magassag { 
        
            get { return magassag; }
            set
            {
                if (value>50 && value<230)
                {
                    magassag = value;
                } else
                {
                    //throw new ArgumentException();
                }
            }
        
        }
        public string Lakhely { get; set; }

        public UjEmber(string nev, int szuletesiEv, int magassag, string lakhely)
        {
            Nev = nev;
            SzuletesiEv = szuletesiEv;
            Magassag = magassag;
            Lakhely = lakhely;
        }

        public UjEmber()
        {

        }

    }
}
