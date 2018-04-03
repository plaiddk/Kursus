using System;
using System.IO;

namespace Opgaver_Using
{
    class Program
    {
        static void Main(string[] args)
        {


            using (StreamReader stream = System.IO.File.OpenText(@"x:\dyrenavne.txt"))
            {

                while (stream.Peek() != -1)
                {
                    string navn = stream.ReadLine();
                    Console.WriteLine(navn);
                }

                stream.Close();
                stream.Dispose();

            }
            



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
