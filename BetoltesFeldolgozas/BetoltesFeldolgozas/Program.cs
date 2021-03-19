using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetoltesFeldolgozas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();

            //Mérés kezdete
            Stopwatch watch=new Stopwatch();

            watch.Start();

            try
            {
                FileStream fajl = new FileStream("snooker.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fajl, Encoding.Default);



                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    try
                    {
                        string[] e = sr.ReadLine().Split(';');
                        Versenyzo versenyzo = new Versenyzo
                        {
                            Helyezes = Convert.ToInt32(e[0]),
                            Nev = e[1],
                            Orszag = e[2],
                            Nyeremeny = Convert.ToInt32(e[3])
                        };

                        versenyzok.Add(versenyzo);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);                      
                    }
                    //feldolgozás
                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            //Mérés vége
            watch.Stop();
            Console.WriteLine($"Feldolgozás ideje:{watch.ElapsedMilliseconds}");

            //Try-catch nélkül kb. átlagosan 25ms

            Console.WriteLine($"A lista elemszáma:{versenyzok.Count}");

            //foreach (var i in versenyzok)
            //{
            //    Console.WriteLine($"{i.Nev},{i.Helyezes},{i.Orszag},{i.Nyeremeny}");
            //}
            
            Console.ReadKey();
        }
    }
}
