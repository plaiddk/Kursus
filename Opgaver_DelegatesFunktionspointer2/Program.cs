using System;

namespace Opgaver_DelegatesFunktionspointer2
{
    class Program
    {
        static void Main(string[] args)
        {


            int res = 0;
            res = Beregner(1, 1, Plus);
            res = Beregner(1, 1, Minus);

            Console.WriteLine(res);




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

       
        //Action = Delegates med en VOID
        //Func = Delegates som returner en int fx
        //Predicate = en bool
        public static int Beregner(int a, int b, Func<int,int,int> funktion)
        {
            return funktion(a, b);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }
}
