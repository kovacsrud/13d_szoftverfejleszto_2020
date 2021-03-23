﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HegyekMo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hegycsucs> hegycsucsok = new List<Hegycsucs>();
            try
            {
                var sorok = File.ReadAllLines("hegyekMo.txt",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    hegycsucsok.Add(new Hegycsucs(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"A hegyek száma:{hegycsucsok.Count}");

            var atlagMagassag = hegycsucsok.Average(x=>x.Magassag);
            Console.WriteLine($"A hegyek átlagos magassága:{atlagMagassag} m");

            var legMagasabb = hegycsucsok.Find(x=>x.Magassag==hegycsucsok.Max(y=>y.Magassag));

            Console.WriteLine($@"A legmagasabb hegycsúcs:
            Név:{legMagasabb.HegycsucsNev}
            Hegység:{legMagasabb.Hegyseg}
            Magasság:{legMagasabb.Magassag} m");

            Console.Write("Kérek egy magasságot:");
            var beMagassag = Convert.ToInt32(Console.ReadLine());

            var vaneHegy = hegycsucsok.FindAll(x=>x.Hegyseg=="Börzsöny" && x.Magassag>beMagassag);

            if (vaneHegy.Count>0)
            {
                Console.WriteLine($"Van {beMagassag} m-nél magasabb hegycsúcs");
            } else
            {
                Console.WriteLine($"Nincs {beMagassag} m-nél magasabb hegycsúcs");
            }



            Console.ReadKey();
        }
    }
}
