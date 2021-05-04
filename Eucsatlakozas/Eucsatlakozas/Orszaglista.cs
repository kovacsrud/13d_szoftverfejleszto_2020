using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eucsatlakozas
{
    public class Orszaglista
    {
        private List<Orszag> orszagok;
        public List<Orszag> Orszagok { get { return orszagok; } }

        public Orszaglista(string fajl,char hatarolo,int start=0)
        {
            orszagok = new List<Orszag>();
            var sorok = File.ReadAllLines(fajl,Encoding.Default);
            for (int i = start; i < sorok.Length; i++)
            {
                orszagok.Add(new Orszag(sorok[i],hatarolo));
            }
        }

        public void UjOrszag(Orszag orszag)
        {
            orszagok.Add(orszag);
        }

    }
}
