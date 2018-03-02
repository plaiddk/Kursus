using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Person k1 = new Person();
            k1.navn = "a";

            Person k2 = new Person();
            k2.navn = "b";

            Console.WriteLine(k1.navn); //Printer a -Fordi det er de sat til i starten
            Console.WriteLine(k2.navn); //Printer b -Fordi det er de sat til i starten

            k1 = k2;


            Console.WriteLine(k1.navn); //Printer b - Fordi vi sætter k1 til at være = k2
            Console.WriteLine(k2.navn); //Printer b - Fordi den er uændret

            k1.navn = "c";


            Console.WriteLine(k1.navn); //Printer c - Fordi nu referer vi k1.navn til at skal være = c
            Console.WriteLine(k2.navn); //Printer b


            Console.ReadKey();

            emps();
        }

        static void emps()
        {
            Console.WriteLine("Ændring til class istedet for struct");
            Employee k1 = new Employee();
            k1.navn = "a";

            Employee k2 = new Employee();
            k2.navn = "b";

            Console.WriteLine(k1.navn); //Printer a - Fordi det er de sat til i starten
            Console.WriteLine(k2.navn); //Printer b - Fordi det er de sat til i starten

            k1 = k2;


            Console.WriteLine(k1.navn); //Printer b - Fordi vi sætter k1 til at være = k2 classen - Så k1 bliver droppet
            Console.WriteLine(k2.navn); //Printer b - Fordi den er uændret

            k1.navn = "c";


            Console.WriteLine(k1.navn); //Printer c - Fordi nu referer vi k1.navn til at skal være = c
            Console.WriteLine(k2.navn); //Printer c - Fordi vi nu referer til et heap k2, da vi ovenoversætte k1 = k2, så er det ligemeget hvad vi ændrer, vi ændre værdien for det heap som vi kun har.
                                        //Dvs k1.navn eller k2.navn vil ændre den samme værdi på det ene heap


            Console.ReadKey();
        }

        class Employee
        {
            public string navn;
        }
        struct Person
        {
            public string navn;
        }
    }
}
