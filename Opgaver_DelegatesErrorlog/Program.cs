using System;

namespace Opgaver_DelegatesErrorlog
{
    class Program
    {
        static void Main(string[] args)
        {


            Maskine m = new Maskine();
            //m.Log = Console.WriteLine;
            m.Log = (tst) =>  Console.WriteLine(tst);
           
            m.Log += (string txt) => { System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n"); };
            m.Start();
            m.Slut();




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        //static void AppendLog(string txt)
        //{
        //    System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        //}
    }

   // public delegate void Skriv(string txt);
    public class Maskine
    {

        public Action<string> Log { get; set; }
       // public Skriv Log { get; set; }

        public void Start()
        {
            Log(DateTime.Now.ToLongDateString() + "Starter");
        }

        public void Slut()
        {
            Log(DateTime.Now.ToLongDateString() + "Slutter");
        }

    }
}
