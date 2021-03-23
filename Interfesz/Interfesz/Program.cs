using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISikidom> sikidomok = new List<ISikidom>();

            Teglalap t1 = new Teglalap(12, 34);
            Teglalap t2 = new Teglalap(18, 56);
            Teglalap t3 = new Teglalap(49, 56);

            Kor k1 = new Kor(35);
            Kor k2 = new Kor(19);
            Kor k3 = new Kor(98);

            sikidomok.Add(t1);
            sikidomok.Add(t2);
            sikidomok.Add(t3);

            sikidomok.Add(k1);
            sikidomok.Add(k2);
            sikidomok.Add(k3);



            Console.ReadKey();
        }
    }
}
