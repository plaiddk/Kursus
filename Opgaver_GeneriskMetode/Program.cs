using System;

namespace Opgaver_GeneriskMetode
{
    class Program
    {
        static void Main(string[] args)
        {



            double i = 10;
            double p = 20;

            Swap(ref i, ref p);



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T tmp = b;
            b = a;
            a = tmp;
        }
    }
}
