using System;

namespace Opgaver_Hændelser
{
    class Program
    {
        static void Main(string[] args)
        {

          
           

            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp\");
            w.EnableRaisingEvents = true;
            w.Changed += (s, e) => { Console.WriteLine("Ændret" + e.FullPath); }; //lambda expression
            w.Created += W_Created; //Metode oprettelse

            do
            {

            } while (true);



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

   
       
        private static void W_Created(object sender, System.IO.FileSystemEventArgs e)
        {
         
            Console.WriteLine("Oprettet" + e.FullPath);
        }
    }
}
