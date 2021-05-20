using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Kutyanev
    {
        public int Id { get; set; }
        public string Kutyaneve { get; set; }

        public Kutyanev(string sor)
        {
            var e = sor.Split(';');
            Id = Convert.ToInt32(e[0]);
            Kutyaneve = e[1];
        }
    }

   
}
