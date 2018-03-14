using System;

namespace Opgaver_Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {


            Person p = new Person();
            p.Fornavn = "Thomas";
            p.Efternavn = "Jensen";

            Console.WriteLine(p.Fuldnavn());

            Elev e = new Elev();
            e.Fornavn = "Thomas";
            e.Efternavn = "Jensen";
            e.Klasselokale = "5.a";


            Console.WriteLine(p.Fuldnavn() + "g�r i "+ e.Klasselokale);

            Instrukt�r i = new Instrukt�r();
            i.Efternavn = "Jensen";
            i.Fornavn = "Thomas";
            i.N�gleId = 1;
            Console.WriteLine(p.Fuldnavn() + " Har n�gleid: " +i.N�gleId);
            Console.WriteLine(i.Fuldnavn());


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string Fuldnavn()
        {
            return Fornavn + " " + Efternavn;


        }
    }

    public class Elev : Person
    {
        public string Klasselokale { get; set; }
    }

    public class Instrukt�r : Person
    {
        public int N�gleId { get; set; }
    }
}
