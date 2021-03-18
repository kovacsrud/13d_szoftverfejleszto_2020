using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FajlokBetolteseKiirasa
{
    class Program
    {
        static void Main(string[] args)
        {
            //A fájlok betöltését szinte mindig Try-catch blokkban
            //érdemes végezni, az esetlegesen jelentkező kivételek
            //miatt
            string[] sorok=null;
            try
            {
                sorok = File.ReadAllLines("snooker.txt", Encoding.Default);
                for (int i = 0; i < sorok.Length; i++)
                {
                    Console.WriteLine(sorok[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

          
            

            try
            {
                FileStream fajl = new FileStream("snooker_copy.txt",FileMode.Create);
                StreamWriter writer = new StreamWriter(fajl,Encoding.Default);

                for (int i = 0; i < sorok.Length; i++)
                {
                    writer.WriteLine(sorok[i]);
                }

                writer.Close();
                Console.WriteLine("Kész!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadKey();
        }
    }
}
