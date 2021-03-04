using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    public class Teglalap
    {
        

        public int Aoldal { get; set; }
        public int Boldal { get; set; }

        public Teglalap(int aoldal, int boldal)
        {
            Aoldal = aoldal;
            Boldal = boldal;
        }

        public int Kerulet()
        {
            return (Aoldal + Boldal) * 2;
        }

        public int Terulet()
        {
            return Aoldal * Boldal;
        }
    }
}
