using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuvekOOP
{
    public enum Eroforrasok
    {
        benzin,
        dízel,
        elektromos,
        hibrid
    }
    public class Gepjarmu
    {
        public Eroforrasok Eroforras { get; set; }
        public int Tomeg { get; set; }
        public int Hossz { get; set; }
        public int MaximalisSebesseg { get; set; }
        public int Teljesitmeny { get; set; }
    }
}
