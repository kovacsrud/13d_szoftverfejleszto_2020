using System;
namespace Oroklodes
{
    public class Allat
    {
        

        public int Eletkor { get; set; }
        public string Megnevezes { get; set; }
        public int Suly { get; set; }

        public Allat(int eletkor, string megnevezes, int suly)
        {
            Eletkor = eletkor;
            Megnevezes = megnevezes;
            Suly = suly;
        }

        //public Allat()
        //{

        //}

        public void Mozog()
        {
            Console.WriteLine("Az állat mozog");
        }

        public virtual void Eszik()
        {
            Console.WriteLine("Az állat eszik");
        }

        public virtual void Iszik()
        {
            Console.WriteLine("Az állat iszik");
        }

        public override string ToString()
        {            
            string osztalyadatok = $"Ez egy állat:{Eletkor} éves,{Megnevezes},{Suly} kg a súlya.";

            return osztalyadatok;
        }
    }
}