using System;
using System.IO;

namespace Opgaver_TryCatchSimple
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();

            try
            {
                p.Run();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Der er sket en fejl " + ex);

                using (StreamWriter writer = new StreamWriter("C:\\temp\\fejl.txt", true))

                {

                    writer.WriteLine("Message :" + ex.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ex.StackTrace +

                       "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());

                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);

                }

            }




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public void Run()
        {
            Console.WriteLine("Indtast 1 tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2 tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("Resultater er " +res);
        }
    }
}
