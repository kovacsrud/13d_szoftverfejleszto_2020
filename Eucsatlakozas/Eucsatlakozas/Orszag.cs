using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eucsatlakozas
{
    public class Orszag
    {
        public string Orszagnev { get; set; }
        public DateTime Csatlakozas { get; set; }

        public Orszag(string sor,char hatarolo)
        {
            var e = sor.Split(hatarolo);
            Orszagnev = e[0];
            Csatlakozas = DateTime.Parse(e[1]);
        }

        public Orszag(string orszagnev, DateTime? csatlakozas)
        {
            Orszagnev = orszagnev;

            if (csatlakozas!=null)
            {
                Csatlakozas = (DateTime)csatlakozas;
            } else
            {
                Csatlakozas = DateTime.Now;

            }
            
            
            
        }
    }
}
