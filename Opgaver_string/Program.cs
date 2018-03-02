using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            string samletString = fornavn + " " + efternavn;

            Console.WriteLine(samletString);


            string navnStort = samletString.ToUpper();

            Console.WriteLine(navnStort);

            string navnLille = samletString.ToLower();

            Console.WriteLine(navnLille);

            string del = samletString.Substring(7, 4);
            Console.WriteLine(del);

            string[] splits = samletString.Split(null); // splitter på whitespace altså mellemrum

            for (int i = 0; i < splits.Length; i++)
            {
                Console.WriteLine(splits[i]);
            }


            //Skriv til en txt fil
            System.IO.File.WriteAllText(@"C:\Users\admin\Desktop\Kursusdag1\string.txt",samletString);
            Console.ReadKey();

            
        }
    }
}
