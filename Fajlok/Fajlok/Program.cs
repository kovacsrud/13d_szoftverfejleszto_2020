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

            Console.ReadKey();
        }
    }
}
