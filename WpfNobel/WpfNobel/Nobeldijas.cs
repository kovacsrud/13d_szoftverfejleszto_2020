using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNobel
{
    public class Nobeldijas
    {
        public int Evszam { get; set; }
        public string Tipus { get; set; }
        public string Keresztnev { get; set; }
        public string Vezeteknev { get; set; }

        public Nobeldijas(string sor,char separator)
        {
            var e = sor.Split(separator);
            Evszam = Convert.ToInt32(e[0]);
            Tipus = e[1];
            Keresztnev = e[2];
            Vezeteknev = e[3];
        }


    }
}
