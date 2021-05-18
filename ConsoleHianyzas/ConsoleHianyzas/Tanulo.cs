using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHianyzas
{
    public class Tanulo
    {
        public string Nev { get; set; }
        public string Osztaly { get; set; }
        public int ElsoNap { get; set; }
        public int UtolsoNap { get; set; }
        public int MulasztottOrak { get; set; }

        public Tanulo(string sor,char hatarolo)
        {
            var e = sor.Split(hatarolo);
            Nev = e[0];
            Osztaly = e[1];
            ElsoNap = Convert.ToInt32(e[2]);
            UtolsoNap = Convert.ToInt32(e[3]);
            MulasztottOrak = Convert.ToInt32(e[4]);
        }
    }
}
