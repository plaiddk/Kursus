using System;
using Newtonsoft;

namespace Opgaver_Interface
{
    class Program
    {
        static void Main(string[] args)
        {


            Hund h = new Hund("Buller");
            h.Gem();

            Ubåd u = new Ubåd() { Nummer = 1 , Tubine = 10.1 } ;
            u.Gem();

            Console.WriteLine();
            Console.WriteLine();

            IDbFunktioner[] i = new IDbFunktioner[3];
            i[0] = new Hund("Hund");
            i[1] = new Ubåd() { Nummer = 2, Tubine = 10.2 };
            i[2] = new Hund("Hunds");

            foreach (IDbFunktioner item in i)
            {
                item.Gem();
            }





            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }

        public Hund(string _navn)
        {
            this.Navn = _navn;
        }


        public void Gem()
        {
            string jsonstring = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            string sti = System.IO.Path.Combine("C:\\temp", this.Navn + ".json");

            System.IO.File.WriteAllText(sti, jsonstring);
            Console.WriteLine("Gemmer Hund");
        }
    }

    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            string jsonstring = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            string sti = System.IO.Path.Combine("C:\\temp", this.Nummer + ".json");

            System.IO.File.WriteAllText(sti, jsonstring);
            Console.WriteLine("Gemmer Ubåd");
        }
       
        
    }

    interface IDbFunktioner
    {
        void Gem();
    }
}
