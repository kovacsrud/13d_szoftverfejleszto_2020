using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class KutyafajtaLista
    {
        private List<Kutyafajta> kutyafajtak;
        public List<Kutyafajta> Kutyafajtak { get { return kutyafajtak; }  }

        public KutyafajtaLista(string fajl)
        {
            kutyafajtak = new List<Kutyafajta>();
            var sorok = File.ReadAllLines(fajl,Encoding.Default);
            for (int i = 1; i < sorok.Length; i++)
            {
                kutyafajtak.Add(new Kutyafajta(sorok[i]));
            }
        }
    }
}
