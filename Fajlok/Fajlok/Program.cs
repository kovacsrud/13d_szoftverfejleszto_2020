using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fajlok
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fajl = new FileStream("snooker.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fajl,Encoding.Default);

            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();

            //Betöltés string tömbbe
            Console.WriteLine("------------------------------");

            var sorok = File.ReadAllLines("snooker.txt",Encoding.Default);

            //for (int i = 1; i < sorok.Length; i++)
            //{
            //    Console.WriteLine(sorok[i]);
            //}

            //Betöltés string változóba
            var szoveg = File.ReadAllText("snooker.txt", Encoding.Default);

            Console.WriteLine(szoveg);

            Console.ReadKey();
        }
    }
}
