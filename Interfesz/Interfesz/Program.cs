using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISikidom> sikidomok = new List<ISikidom>();

            Teglalap t1 = new Teglalap(12, 34);
            Teglalap t2 = new Teglalap(18, 56);
            Teglalap t3 = new Teglalap(49, 56);

            Kor k1 = new Kor(35);
            Kor k2 = new Kor(19);
            Kor k3 = new Kor(98);

            Rombusz r1 = new Rombusz(12, 30);
            Rombusz r2 = new Rombusz(39, 26);
            Rombusz r3 = new Rombusz(51, 39);

            sikidomok.Add(t1);
            sikidomok.Add(t2);
            sikidomok.Add(t3);

            sikidomok.Add(k1);
            sikidomok.Add(k2);
            sikidomok.Add(k3);

            sikidomok.Add(r1);
            sikidomok.Add(r2);
            sikidomok.Add(r3);

            //Síkidomok összes kerülete, területe
            var osszKerulet = sikidomok.Sum(x=>x.Kerulet());
            var osszTerulet = sikidomok.Sum(x=>x.Terulet());

            Console.WriteLine($"Az kerületek összege:{osszKerulet}");
            Console.WriteLine($"A területek összege:{osszTerulet}");

            //Körök kerülete, területe

            var korKerulet = sikidomok.FindAll(x=>x.GetType()==typeof(Kor)).Sum(x=>x.Kerulet());
            Console.WriteLine($"A körök kerülete:{korKerulet}");

            var teglalapKerulet = sikidomok.FindAll(x => x.GetType() == typeof(Teglalap)).Average(x=>x.Kerulet());
            Console.WriteLine($"A téglalapok kerülete:{teglalapKerulet}");

            //Tetszőleges síkidom megvalósítása
            var rombuszTerulet = sikidomok.FindAll(x=>x.GetType()==typeof(Rombusz)).Sum(x=>x.Terulet());
            Console.WriteLine($"A rombuszok területe:{rombuszTerulet}");



            Console.ReadKey();
        }
    }
}

