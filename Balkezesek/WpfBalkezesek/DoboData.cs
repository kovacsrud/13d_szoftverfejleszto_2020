using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Balkezesek;

namespace WpfBalkezesek
{
    public class DoboData
    {
        private List<Dobo> dobok;
        public List<Dobo> Dobok { get { return dobok; } }

        public DoboData(string fajl,int start=0)
        {
            dobok = new List<Dobo>();
            var sorok = File.ReadAllLines(fajl,Encoding.Default);
            for (int i = start; i < sorok.Length; i++)
            {
                dobok.Add(new Dobo(sorok[i]));
            }
        }
    }
}
