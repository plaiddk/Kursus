using System;

namespace Opgaver_Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {


            Person p = new Person();
            p.Fornavn = "Thomas";
            p.Efternavn = "Jensen";
            p.Skriv();

            Elev e = new Elev();
            e.Fornavn = "Thomas";
            e.Efternavn =  "Jensen";
            e.Klasselokale  = "5.a";
            e.Skriv();

            Instruktør i = new Instruktør();
            i.Fornavn = "Thomas";
            i.Efternavn = "Jensen";
            i.NøgleId = 1;
            i.Skriv();

            Person[] pa = new Person[3];
            pa[0] = p;
            pa[1] = e;
            pa[2] = i;
        

            foreach (var item in pa)
            {
                item.Skriv();
            }


            Console.WriteLine();
            Console.WriteLine();

            Person p2 = new Elev() { Efternavn = "thomas", Fornavn = "jernsen" , Klasselokale = "5.a" };
         
           

            p2.Skriv();

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

        public  virtual void  Skriv()
        {
            Console.WriteLine(Fornavn+  " " + Efternavn);
        }

    }

    public class Elev : Person
    {
        public string Klasselokale { get; set; }

        public override void Skriv()
        {
            Console.WriteLine(Fornavn + " " + Efternavn + " " + Klasselokale);
        }

    }

    public class Instruktør : Person
    {

        public int NøgleId { get; set; }

        public override void Skriv()
        {
            Console.WriteLine(Fornavn + " " + Efternavn + " " + NøgleId);
        }



    }

}
