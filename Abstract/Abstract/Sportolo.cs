using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Sportolo : Ember
    {
        public string Sportag { get; set; }
        public override void Alszik()
        {
            Console.WriteLine("A sportoló sokat alszik");
        }

        public override void Eszik()
        {
            Console.WriteLine("A sportoló sokat eszik");
        }

        public override void Mozog()
        {
            Console.WriteLine("A sportoló lendületesen mozog");
        }

        public void Edz()
        {
            Console.WriteLine("A sportoló edz");
        }
    }
}
