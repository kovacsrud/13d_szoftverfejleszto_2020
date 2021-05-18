using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaGyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Jarmu> jarmuvek = new List<Jarmu>();

            var elemszam = rand.Next(200, 501);
            String[] kategoria = { "személyautó", "teherautó", "traktor", "munkagép" };

            for (int i = 0; i < elemszam; i++)
            {
                var kat = kategoria[rand.Next(0, kategoria.Length)];
                var telj = rand.Next(60, 500 + 1);
                var gyartev = rand.Next(1980, 2021 + 1);
                Jarmu jarmu = new Jarmu(kat, telj, gyartev);

                //Így is lehet példányosítani
                Jarmu jarmumasik = new Jarmu
                {
                    Kategoria = kat,
                    Teljesitmeny = telj,
                    GyartasiEv = gyartev
                };

                jarmuvek.Add(jarmu);
            }

            Console.WriteLine($"A lista elemszáma:{jarmuvek.Count}");

            //JarmuLista(jarmuvek);
            //A legkisebb gyártási év:
            var minGyartev = jarmuvek.Min(x => x.GyartasiEv);
            Console.WriteLine($"Legkisebb gyártási év:{minGyartev}");

            //Azon járművek listája, amelyeknél a gyártási év a legkisebb
            var oregJarmuvek = jarmuvek.FindAll(x=>x.GyartasiEv==minGyartev);
            JarmuLista(oregJarmuvek);

            var regi = jarmuvek.Find(x => x.GyartasiEv == 1981);

            //Ha Find-ot használunk, akkor abban az esetben, ha nincs a feltételnek
            //megfelelő elem, akkor a bal oldali változó értéke null lesz. Ezért
            //érdemes az ilyen változókat null-értékre ellenőrizni, hogy ne kapjunk 
            //kivételt
            if (regi!=null)
            {
                Console.WriteLine($"{regi.Kategoria}");
            }

            //1990-ben gyártott traktorok
            var traktorok = jarmuvek.FindAll(x=>x.Kategoria=="traktor" && x.GyartasiEv==1990);
            JarmuLista(traktorok);

            //1990 után gyártott teherautók
            var teherautok = jarmuvek.FindAll(x=>x.Kategoria=="teherautó" && x.GyartasiEv>1990);
            JarmuLista(teherautok);

            //1995 után gyártott személyautók, ahol a teljesítmény 200-nál nagyobb
            var szemelyautok = jarmuvek.FindAll(x=>x.Kategoria=="személyautó" && x.GyartasiEv>1995 && x.Teljesitmeny>80);
            JarmuLista(szemelyautok);


            Console.ReadKey();
        }

        private static void JarmuLista(List<Jarmu> jarmuvek)
        {
            foreach (var i in jarmuvek)
            {
                Console.WriteLine($"{i.Kategoria},{i.Teljesitmeny},{i.GyartasiEv}");
            }
        }
    }
}
