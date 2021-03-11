using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    public enum SzorTipus
    {
        hosszúszőrű,
        rövidszőrű
    }
    public class Macska : Allat
    {
        public String Fajta { get; set; }
        public string Szin  { get; set; }
        public bool IsHosszuSzoru { get; set; }

        public SzorTipus Szortipus { get; set; }

        public Macska(int eletkor, string megnevezes, int suly, string fajta, string szin, bool isHosszuSzoru, SzorTipus szortipus) : base(eletkor, megnevezes, suly)
        {
            Fajta = fajta;
            Szin = szin;
            IsHosszuSzoru = isHosszuSzoru;
            Szortipus = szortipus;
        }

        public void Nyavog()
        {
            Console.WriteLine("A macska nyávog");
        }

        public override string ToString()
        {
            string osztalyadatok = base.ToString();
            osztalyadatok += $" Ez az állat egy macska,{Fajta} fajtájú,{Szin} színű,";

            if (IsHosszuSzoru)
            {
                osztalyadatok += " hosszú szőrű";
            } else
            {
                osztalyadatok += " rövid szőrű";
            }

            return osztalyadatok;
        }
    }
}
