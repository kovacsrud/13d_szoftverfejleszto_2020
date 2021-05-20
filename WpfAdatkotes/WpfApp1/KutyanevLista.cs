using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class KutyanevLista
    {
        private List<Kutyanev> kutyanevek;
        public List<Kutyanev> Kutyanevek { get { return kutyanevek;}  }

        public KutyanevLista(string fajl)
        {
            kutyanevek = new List<Kutyanev>();
            var sorok = File.ReadAllLines(fajl,Encoding.Default);
            for (int i = 1; i < sorok.Length; i++)
            {
                kutyanevek.Add(new Kutyanev(sorok[i]));

            }
            
        }


    }
}
