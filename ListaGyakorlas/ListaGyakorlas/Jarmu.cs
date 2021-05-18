using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaGyakorlas
{
    public class Jarmu
    {
        

        public string Kategoria { get; set; }

        private int teljesitmeny;
        public int Teljesitmeny {
            get { return teljesitmeny; }
            set
            {
                if (Kategoria=="személyautó" && value>120)
                {
                    teljesitmeny = 120;
                } else
                {
                    teljesitmeny = value;
                }
            }
                
        
        }
            
        
        public int GyartasiEv { get; set; }

        public Jarmu(string kategoria, int teljesitmeny, int gyartasiEv)
        {
            Kategoria = kategoria;
            Teljesitmeny = teljesitmeny;
            GyartasiEv = gyartasiEv;
        }

        public Jarmu()
        {

        }

    }
}
