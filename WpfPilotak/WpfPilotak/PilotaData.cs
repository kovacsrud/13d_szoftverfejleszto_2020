using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPilotak
{
    public class PilotaData
    {
        private List<Pilota> pilotak;
        public List<Pilota> Pilotak { get { return pilotak; }  }

        public PilotaData(string fajl,char hatarolo,int start=0)
        {
            pilotak = new List<Pilota>();
            var sorok = File.ReadAllLines(fajl,Encoding.Default);
            for (int i = start; i < sorok.Length; i++)
            {
                pilotak.Add(new Pilota(sorok[i],hatarolo));
            }
        }

        public List<int> GetSzuletesiEv()
        {
            List<int> evek = new List<int>();

            var evLookup = pilotak.ToLookup(x=>x.SzuletesiDatum.Year).OrderBy(x=>x.Key);

            foreach (var i in evLookup)
            {
                evek.Add(i.Key);
            }
            return evek;
        }
    }
}
