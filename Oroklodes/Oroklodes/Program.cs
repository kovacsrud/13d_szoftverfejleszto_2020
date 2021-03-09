using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Program
    {
        static void Main(string[] args)
        {

            Allat allat = new Allat(6, "kutya", 12);
            allat.Mozog();
            allat.Iszik();
            allat.Eszik();

            Console.WriteLine(allat.ToString());

            Kutya kutya = new Kutya(6, "kutya", 35, "komondor", "fehér"); 
           
            kutya.Iszik();
            kutya.Eszik();
            kutya.Ugat();
            Console.WriteLine(kutya.ToString());

            Console.ReadKey();
        }
    }
}
