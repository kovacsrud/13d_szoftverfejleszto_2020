using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorokOOP
{
    public enum Anyag
    {
        fa,
        fém,
        műanyag
    }
    public class Butor
    {
        public int Suly { get; set; }
        public int MaxMagassag { get; set; }
        public Anyag JellemzoAnyag { get; set; }

    }
}
