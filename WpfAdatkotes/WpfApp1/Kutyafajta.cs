using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Kutyafajta
    {
        public int Id { get; set; }
        public string Fajtanev { get; set; }
        public string FajtaEredetinev { get; set; }

        public Kutyafajta(string sor)
        {
            var e = sor.Split(';');
            Id = Convert.ToInt32(e[0]);
            Fajtanev = e[1];
            FajtaEredetinev = e[2];
        }
    }
}
