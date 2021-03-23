using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    
    public class Rombusz:ISikidom
    {

        const double RAD = 0.017453292519943;
        public double Oldal { get; set; }

        public int Szog { get; set; }
        public double Magassag { get; set; }

        public Rombusz(double oldal, int szog)
        {
            
            Oldal = oldal;
            Szog = szog;
            Magassag = Oldal * Math.Sin(Szog * RAD);
        }

        public double Kerulet()
        {
            return 4 * Oldal;
        }

        public double Terulet()
        {
            return Oldal * Magassag;
        }

        
    }
}
