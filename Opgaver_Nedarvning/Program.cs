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


            Console.WriteLine(p.Fuldnavn() + "går i "+ e.Klasselokale);

            Instruktør i = new Instruktør();
            i.Efternavn = "Jensen";
            i.Fornavn = "Thomas";
            i.NøgleId = 1;
            Console.WriteLine(p.Fuldnavn() + " Har nøgleid: " +i.NøgleId);
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

    public class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }
}
