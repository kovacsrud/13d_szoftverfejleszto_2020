using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNobel
{
    public class NobelLista
    {
        private List<Nobeldijas> nobeldijasok;
        public List<Nobeldijas> Nobeldijasok { get { return nobeldijasok; } }

        public NobelLista(string fajl,char separator,int start=0)
        {
            nobeldijasok = new List<Nobeldijas>();
            var sorok = File.ReadAllLines(fajl,Encoding.Default);
            for (int i = start; i < sorok.Length; i++)
            {
                nobeldijasok.Add(new Nobeldijas(sorok[i],separator));
            }
        }


    }
}
