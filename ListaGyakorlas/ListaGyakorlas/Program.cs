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
                var kat = kategoria[rand.Next(0,kategoria.Length)];
                var telj = rand.Next(60,500+1);
                var gyartev = rand.Next(1980, 2021 + 1);
                Jarmu jarmu = new Jarmu(kat,telj,gyartev);

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

            foreach (var i in jarmuvek)
            {
                Console.WriteLine($"{i.Kategoria},{i.Teljesitmeny},{i.GyartasiEv}");
            }

            Console.ReadKey();
        }
    }
}
