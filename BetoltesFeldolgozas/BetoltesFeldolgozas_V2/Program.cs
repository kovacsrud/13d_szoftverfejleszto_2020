using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetoltesFeldolgozas_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();

            try
            {
                var sorok = File.ReadAllLines("snooker.txt", Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    versenyzok.Add(new Versenyzo(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Elemszám:{versenyzok.Count}");

            //Angol versenyzők adatai
            var angolok = versenyzok.FindAll(x=>x.Orszag=="Anglia");

            foreach (var i in angolok)
            {
                Console.WriteLine($"{i.Orszag},{i.Nev},{i.Helyezes},{i.Nyeremeny}");
            }
            //Adatok fájlba írása
            try
            {
                FileStream fajl = new FileStream("angolok.txt",FileMode.Create);
                StreamWriter wr = new StreamWriter(fajl,Encoding.Default);

                foreach (var i in angolok)
                {
                    wr.WriteLine($"{i.Orszag},{i.Nev},{i.Helyezes},{i.Nyeremeny}");
                }
                wr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadKey();
        }
    }
}
