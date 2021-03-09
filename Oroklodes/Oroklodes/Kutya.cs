using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    public class Kutya:Allat
    {
        

        public string Fajta { get; set; }
        public string Szin { get; set; }

        public Kutya(int eletkor, string megnevezes, int suly,string fajta,string szin) : base(eletkor, megnevezes, suly)
        {
            Fajta = fajta;
            Szin = szin;
        }

        public void Ugat()
        {
            Console.WriteLine("A kutya ugat");
        }

        public override void Iszik()
        {
            Console.WriteLine("A kutya iszik");
        }

        public override void Eszik()
        {
            Console.WriteLine("A kutya eszik");
        }

        public override string ToString()
        {
            string osztalyadatok = base.ToString();
            osztalyadatok += $" Ez az állat egy kutya,{Fajta} fajtájú,{Szin} színű.";
            return osztalyadatok;
        }


    }
}
