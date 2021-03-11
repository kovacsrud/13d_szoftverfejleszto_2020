using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuvekOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Szemelyszallito> szemelyszallitok = new List<Szemelyszallito>();
            List<Munkagep> munkagepek = new List<Munkagep>();
            List<Gepjarmu> gepjarmuvek = new List<Gepjarmu>();

            Szemelyszallito sz1 = new Szemelyszallito 
            {
                Hossz=4,
                Alvazszam="A111B222",
                Eroforras="benzin",
                Motorszam="M222B5354",
                MaximalisSebesseg=150,
                Szemelyek=5,
                Teljesitmeny=80,
                Tomeg=1300
                
            };

            Szemelyszallito sz2 = new Szemelyszallito
            {
                Hossz = 5,
                Alvazszam = "A112B224",
                Eroforras = "dízel",
                Motorszam = "M111B5411",
                MaximalisSebesseg = 180,
                Szemelyek = 7,
                Teljesitmeny = 180,
                Tomeg = 1400

            };

            Munkagep m1 = new Munkagep
            {
                MaximalisSebesseg=30,
                AlkalmazasiTerulet="homlokrakodó",
                Eroforras="diesel",
                Hossz=10,
                IsKozforgalom=true,
                Teljesitmeny=300,
                Tomeg=5400
            };

            Munkagep m2 = new Munkagep
            {
                MaximalisSebesseg = 10,
                AlkalmazasiTerulet = "úthenger",
                Eroforras = "diesel",
                Hossz = 8,
                IsKozforgalom = false,
                Teljesitmeny = 450,
                Tomeg = 7500
            };

            szemelyszallitok.Add(sz1);
            szemelyszallitok.Add(sz2);

            munkagepek.Add(m1);
            munkagepek.Add(m2);

            gepjarmuvek.Add(sz1);
            gepjarmuvek.Add(sz2);
            gepjarmuvek.Add(m1);
            gepjarmuvek.Add(m2);

            var mgGyorsabb = munkagepek.FindAll(x => x.MaximalisSebesseg > 10 && x.IsKozforgalom);

            foreach (var i in mgGyorsabb)
            {
                Console.WriteLine($"{i.MaximalisSebesseg},{i.Eroforras},{i.Tomeg}");
            }

            var tobbSzemely = szemelyszallitok.FindAll(x=>x.Szemelyek>5);

            foreach (var i in tobbSzemely)
            {
                Console.WriteLine($@"
                {i.Szemelyek},
                {i.Teljesitmeny},
                {i.MaximalisSebesseg},
                {i.Eroforras}
                {i.Motorszam}
                ");
            }

            var tobb2 = szemelyszallitok.Where(x=>x.Szemelyek>5);


            foreach (var i in gepjarmuvek)
            {
                if (i.GetType()==typeof(Szemelyszallito))
                {
                    Szemelyszallito sz = (Szemelyszallito)i;
                    if (sz.Szemelyek>5)
                    {
                        Console.WriteLine($"{sz.Szemelyek},{sz.MaximalisSebesseg}");
                    }
                }
            }
            

            Console.ReadKey();
        }
    }
}
