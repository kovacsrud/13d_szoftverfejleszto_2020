using KRHash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHash hash = new CreateHash();
            Console.WriteLine(hash.MakeHash(HashType.MD5,"Valami"));
            Console.WriteLine(hash.MakeHash(HashType.MD5, "Valami",true));

            Console.WriteLine(hash.MakeHash(HashType.SHA512, "Valami"));
            Console.WriteLine(hash.MakeHash(HashType.SHA512, "Valami", true));

            Console.ReadKey();
        }
    }
}
