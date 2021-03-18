using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Tanulo : Ember
    {
        public string Iskola { get; set; }
        public override void Alszik()
        {
            Console.WriteLine("A tanuló későn fekszik, keveset alszik");
        }

        public override void Eszik()
        {
            Console.WriteLine("A tanuló igyekszik nem sokat enni");
        }

        public override void Mozog()
        {
            Console.WriteLine("A tanuló néha keveset mozog");
        }

        public void Tanul()
        {
            Console.WriteLine("A tanuló sokat tanul");
        }
    }
}
