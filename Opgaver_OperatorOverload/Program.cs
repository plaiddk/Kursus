using System;

namespace Opgaver_OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {


            Hund h1 = new Hund() { Navn = "a", Lydniveau = 10 };
            Hund h2 = new Hund() { Navn = "b", Lydniveau = 20 };

            Console.WriteLine(h1!=h2);




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

      
    }

    public class Hund
    {
        public string Navn { get; set; }

        public int Lydniveau { get; set; }


        public static bool operator <(Hund h1, Hund h2)
        {
            return h1.Lydniveau < h2.Lydniveau;
        }
        public static bool operator >(Hund h1, Hund h2)
        {
            return h1.Lydniveau > h2.Lydniveau;
        }


        public static bool operator == (Hund h1, Hund h2)
        {
            return h1.Lydniveau == h2.Lydniveau;
        }
        public static bool operator != (Hund h1, Hund h2)
        {
            return h1.Lydniveau != h2.Lydniveau;
        }

    }
}
