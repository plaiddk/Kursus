using System;

namespace Opgaver_DelegatesFunktionspointer
{
    class Program
    {
        static void Main(string[] args)
        {


            int res = Beregner(1, 1, Plus);
            res = Beregner(1, 1, Minus);

            Beregn d1 = Plus;
            var res3 = d1.Invoke(1, 1);
            Console.WriteLine(res3);

            Console.WriteLine();
            Console.WriteLine(res);



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public delegate int Beregn(int a, int b);

        public static int Beregner(int a, int b, Beregn funktion)
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
        public static int Divider(int a,int b)
        {
            return a / b;
        }

        public static int Gange(int a ,int b)
        {
            return a * b;
        }
    }
}
