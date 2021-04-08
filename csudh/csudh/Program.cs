using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csudh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Domain> domainek = new List<Domain>();
            try
            {
                var sorok = File.ReadAllLines("csudh.txt",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    domainek.Add(new Domain(sorok[i],';'));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"3.feladat Domainek száma:{domainek.Count}");

            Console.WriteLine($"5.feladat: Az első domain felépítése");

            var elso = domainek.First();

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"{i}.szint:{elso.DomainLevel(i)}");
            }

            string html = "<HTML>\n";
            html += "<HEAD>\n";
            html += "<TITLE>Domain lista</TITLE>\n";
            html += "</HEAD>\n";
            html += "<BODY>\n";
            html += "<TABLE>\n";
            html += "<TR>\n";
            html += "<TH style='text-align:left'>Ssz</TH>\n";
            html += "<TH style='text-align:left'>Host domain neve</TH>\n";
            html += "<TH style='text-align:left'>Host IP címe</TH>\n";
            for (int i = 1; i < 6; i++)
            {
                html += $"<TH style='text-align:left'>{i}.szint</TH>\n";
            }
            html += "</TR>\n";
            int sorszam = 1;
            foreach (var i in domainek)
            {
                html += "<TR>\n";
                html += $"<TD>{sorszam}.</TD>\n";
                html += $"<TD>{i.DomainName}</TD>\n";
                html += $"<TD>{i.IpAddress}</TD>\n";
                for (int j = 1; j < 6; j++)
                {
                    html += $"<TD>{i.DomainLevel(j)}</TD>\n";
                }
                html += "</TR>\n";
                sorszam++;
            }
            html += "</TABLE>\n";

            html += "</BODY>\n";
            html += "</HTML>\n";

            try
            {
                File.WriteAllText("table.html",html);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
