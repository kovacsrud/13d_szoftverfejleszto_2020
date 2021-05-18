using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleHianyzas;

namespace WpfHianyzas
{
    public class TanuloAdatok
    {
        private List<Tanulo> tanulok;
        public List<Tanulo> Tanulok { get { return tanulok; } }

        public TanuloAdatok(string fajl,char hatarolo,int start=0)
        {
            tanulok = new List<Tanulo>();
            var sorok = File.ReadAllLines(fajl,Encoding.Default);
            for (int i = start; i < sorok.Length; i++)
            {
                tanulok.Add(new Tanulo(sorok[i],hatarolo)) ;
            }
        }
    }
}
