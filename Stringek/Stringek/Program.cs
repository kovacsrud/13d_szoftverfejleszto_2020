using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringek
{
    class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "Valami szöveg";
            szoveg = "ValAmi mÁs sZöveG";

            Console.WriteLine(szoveg.Length);

            for (int i = 0; i < szoveg.Length; i++)
            {
                Console.WriteLine(szoveg[i]);
            }

            Console.WriteLine(szoveg.ToLower());

            Console.WriteLine(szoveg.ToUpper());

            Console.WriteLine(szoveg.StartsWith("Val"));
            Console.WriteLine(szoveg.StartsWith("val"));

            Console.WriteLine(szoveg.EndsWith("veG"));

            Console.WriteLine(szoveg.ToLower().Contains("más".ToLower()));

            Console.WriteLine(szoveg.Replace('a','ö'));
            Console.WriteLine(szoveg.Replace(" ", ""));
            Console.WriteLine(szoveg.Replace("ValAmi", "bármi"));






            Console.ReadKey();
        }
    }
}
