using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            //tippek tárolása->tömb vagy lista
            //nyerőszámok tárolása->tömb vagy lista
            //nyerőszámok száma: hány számmal játszunk?
            //hány számból húzunk ?
            //találatok száma

            //Annak a bekérése hogy hány számmal játszunk
            //és hogy mennyiből húzunk
            Console.Write("Hány számmal játszunk?:");
            int hanySzam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mennyiből húzunk?");
            int mennyiSzam = Convert.ToInt32(Console.ReadLine());

            int[] tippek = new int[hanySzam];
            int[] nyeroSzamok = new int[hanySzam];
            int talalat = 0;
            char valasz = 'n';
            

            Random rand = new Random();

           


                //Tippek bekérése
                for (int i = 0; i < hanySzam; i++)
                {
                    Console.Write($"{i + 1}.tipp:");
                    int temp = Convert.ToInt32(Console.ReadLine());
                    while (temp < 1 || temp > mennyiSzam || tippek.Contains(temp))
                    {
                        Console.Write($"A tipp rossz,{i + 1}.tipp újra:");
                        temp = Convert.ToInt32(Console.ReadLine());
                    }
                    tippek[i] = temp;

                }

                //Tippek listázása
                TombLista(tippek);
            int sorsolasok = 0;
            do
            {
                //Nyerőszámok sorsolása
                for (int i = 0; i < hanySzam; i++)
                {
                    int temp = rand.Next(1, mennyiSzam + 1);
                    while (nyeroSzamok.Contains(temp))
                    {
                        temp = rand.Next(1, mennyiSzam + 1);
                    }
                    nyeroSzamok[i] = temp;
                }

                //TombLista(nyeroSzamok);

                //Találatok meghatározása

                for (int i = 0; i < tippek.Length; i++)
                {
                    for (int j = 0; j < nyeroSzamok.Length; j++)
                    {
                        if (tippek[i] == nyeroSzamok[j])
                        {
                            talalat += 1;
                        }
                    }
                }

                talalat = 0;

                for (int i = 0; i < tippek.Length; i++)
                {
                    if (nyeroSzamok.Contains(tippek[i]))
                    {
                        talalat++;
                    }
                }

                if (talalat>0)
                {
                    Console.WriteLine($"Találatok:{talalat}");
                }
                


                sorsolasok++;

                //Console.Write("Akar újat játszani?(i/n)");
                //valasz = Console.ReadKey().KeyChar;
                valasz = 'i';

            } while (talalat<5);

            Console.WriteLine($"Sorsolások száma:{sorsolasok}");
            Console.WriteLine($"Ez években kifejezve:{sorsolasok/52}");

            //Módosítsa úgy a programot, hogy adott számú találatig fusson!
            //Határozza meg, hogy ez mennyi időbe telt volna.



            Console.ReadKey();
        }

        private static void TombLista(int[] tomb)
        {
            Array.Sort(tomb);
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
