using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] månedsLøn = { 1000, 2000, 49890, 5000, 1000 };

            int printeVærdien;
            double liggeTalSammen = 0;
           

            //Printe selve værdien
            for (int i = 0; i < månedsLøn.Length; i++)
            {
                printeVærdien = månedsLøn[i];

                Console.WriteLine("Her printer jeg den aktuelle værdi");
                Console.WriteLine(printeVærdien);

               
                Console.ReadKey();
            }

            //Printe tallene bliver lagt sammen

            double sum = 0;

            for (int i = 0; i < månedsLøn.Length; i++)
            {
                liggeTalSammen += månedsLøn[i];

                Console.WriteLine("Her printer jeg adderingen af de forskellige værdier");
                Console.WriteLine(liggeTalSammen);
              
                Console.ReadKey();
            }

            sum = liggeTalSammen / månedsLøn.Count(); //Alternativ length

            Console.WriteLine("Her printer jeg gns");

            //Formatering af tallet
            Console.WriteLine(sum.ToString("N2"));
            Console.ReadKey();
        }
    }
}

