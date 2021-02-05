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

            string datum="2021.02.05";

            var ev = datum.Substring(0, 4);
            var honap = datum.Substring(5,2);
            var nap = datum.Substring(8,2);

            Console.WriteLine(ev);
            Console.WriteLine(honap);
            Console.WriteLine(nap);

            var datumelemek = datum.Split('.');

            foreach (var i in datumelemek)
            {
                Console.WriteLine(i);
            }

            string dirtystring = "@#      dirty  !    %";

            char[] levagandok = { '@', '#', ' ', '!', '%' };
            Console.WriteLine(dirtystring.Trim(levagandok));
            Console.WriteLine(dirtystring.TrimStart(levagandok));
            Console.WriteLine(dirtystring.TrimEnd(levagandok));

            string cserelendo = "KisBetűsT NagyBetűSrE";
            Console.WriteLine(cserelendo);
            char[] cserelendochar = cserelendo.ToCharArray();

            for (int i = 0; i < cserelendochar.Length; i++)
            {
                if (Char.IsUpper(cserelendochar[i]))
                {
                    cserelendochar[i] = Char.ToLower(cserelendochar[i]);
                }
                 else
                {
                    cserelendochar[i] = Char.ToUpper(cserelendochar[i]);
                }
            }

            cserelendo = new string(cserelendochar);

            Console.WriteLine(cserelendo);

            string osszeadni = "124677849952532";
            //próbáljuk meg önállóan összeadni a string-ben lévő
            //számokat










            Console.ReadKey();
        }
    }
}
