using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorokOOP
{
    public enum Alak
    {
        négyzet,
        kör,
        ellipszis,
        téglalap,
        hatszög
    }
    public class Asztal:Butor
    {
        public Alak AsztallapAlak { get; set; }
        public bool Fiokos { get; set; }
    }
}
