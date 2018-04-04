using System;

namespace Opgaver_DelegatesFunktionspointer3
{
    class Program
    {
        static void Main(string[] args)
        {


            int res = 0;
            res = Beregner(1, 1, Plus);
            res = Beregner(1, 1, Minus);

            Console.WriteLine(res);

            Console.WriteLine();

            res = Beregner(1, 1, FindTilfældigFunktion());
            Console.WriteLine(res);

            Console.WriteLine();
            res = Beregner(3, 4, FindTilfældigFunktion());
            Console.WriteLine(res);



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public static int Beregner(int a, int b, Func<int, int, int> funktion)
        {
            return funktion(a, b);
        }

        public static  Func<int,int,int>  FindTilfældigFunktion()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return Plus;
            if (System.DateTime.Now.Millisecond <= 500)
                return Minus;
            if (System.DateTime.Now.Millisecond <= 750)
                return Gange;
            return Divider;


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
