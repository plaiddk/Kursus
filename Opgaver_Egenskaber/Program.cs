using System;

namespace Opgaver_Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            p.Fornavn = "Thomas";
            p.Efternavn = "Jensen";

            Console.WriteLine(p.FuldNavn());


            Vare v = new Vare();
            v.Navn = "Cola";
            v.Pris = 10;
            Console.WriteLine(v.PrisMedMoms());


            Vare v2 = new Vare(100, "Pepsi");
            Console.WriteLine(v2.Navn+ " " +v2.PrisMedMoms());

            Trekant t = new Trekant(10,2);

            Console.WriteLine(t.Areal);
            Console.WriteLine(t.ArealMetode());

            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));
            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10,10));
            
            
            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
