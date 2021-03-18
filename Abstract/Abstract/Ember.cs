using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Ember
    {
        public string Nev { get; set; }
        public int SzuletesiEv { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }

        public abstract void Eszik();

        public abstract void Alszik();

        public abstract void Mozog();

        public int GetEletkor()
        {
            return DateTime.Now.Year-SzuletesiEv;
        }


    }
}
