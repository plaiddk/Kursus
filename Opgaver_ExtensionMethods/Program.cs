using System;

namespace Opgaver_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {


            string r = "søren";
            Console.WriteLine(r.FormatName());




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

    }

    public static class ExtensionMethods
    {

        public static string FormatName(this string værdi)
        {
            if (værdi.Length > 0)
            {
                char[] array = værdi.ToCharArray();
                array[0] = char.ToUpper(array[0]);

                return new string(array);
            }
            return værdi;
        }
    }
}
