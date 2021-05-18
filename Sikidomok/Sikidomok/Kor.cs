using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    public class Kor
    {
        public int Sugar { get; set; }

        public double Kerulet()
        {
            return 2 * Sugar * Math.PI;
        }

        public double Terulet()
        {
            return Sugar * Sugar * Math.PI;
        }


    }
}
