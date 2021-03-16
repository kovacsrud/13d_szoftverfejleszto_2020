using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorokOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Szekreny> szekrenyek = new List<Szekreny>();
            List<Asztal> asztalok = new List<Asztal>();

            Szekreny sz1 = new Szekreny
            {
                Suly=60,
                JellemzoAnyag=Anyag.fa,
                KulccsalZarhato=true,
                MaxMagassag=180,
                Uveges=true
            };

            Szekreny sz2 = new Szekreny
            {
                Suly = 40,
                JellemzoAnyag = Anyag.fém,
                KulccsalZarhato = true,
                MaxMagassag = 150,
                Uveges = true
            };

            szekrenyek.Add(sz1);
            szekrenyek.Add(sz2);

            Asztal a1 = new Asztal
            {
                AsztallapAlak=Alak.téglalap,
                JellemzoAnyag=Anyag.fa,
                Fiokos=false,
                MaxMagassag=60,
                Suly=20
            };

            Asztal a2 = new Asztal
            {
                AsztallapAlak=Alak.kör,
                JellemzoAnyag=Anyag.műanyag,
                Fiokos=false,
                MaxMagassag=60,
                Suly=5
            };

            asztalok.Add(a1);
            asztalok.Add(a2);

            //Legnehezebb szekrény adatainak
            //meghatározása

            var maxSuly = szekrenyek.Max(x=>x.Suly);

            var maxSulySzekreny = szekrenyek.Find(x=>x.Suly==maxSuly);

            Console.WriteLine($@"{maxSulySzekreny.JellemzoAnyag}
            {maxSulySzekreny.MaxMagassag}
            {maxSulySzekreny.Suly}
            {maxSulySzekreny.Uveges}");

            var maxSz = szekrenyek.Find(x=>x.Suly==szekrenyek.Max(y=>y.Suly));

            var kulcsFem = szekrenyek.FindAll(x=>x.KulccsalZarhato && x.Uveges && x.JellemzoAnyag==Anyag.fém);

            foreach (var i in kulcsFem)
            {
                Console.WriteLine($"{i.JellemzoAnyag},{i.MaxMagassag},{i.KulccsalZarhato},{i.Uveges}");
            }

            Console.ReadKey();
        }
    }
}
