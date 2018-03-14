using System;

namespace Opgaver_NedarvningRandom
{
    class Program
    {
        static void Main(string[] args)
        {


            UdvidetRandom r = new UdvidetRandom();

            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.values);




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    //Nedarvning
    public class UdvidetRandom1 : System.Random
    {
        public bool NextBool()
        {
            return this.Next(1, 1002) < 500;
        }
    }

    //Klasse som returnerer tal og next
    public class UdvidetRandom
    {
        public int values { get; set; }
        public bool  NextBool()
        {
            System.Random rnd = new System.Random();
            values = rnd.Next(1, 1002);

            if (values< 500)
            {
                
                return true;
            }
            else
                return false;
      
        }
    }
}
