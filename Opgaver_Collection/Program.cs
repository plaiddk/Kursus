using System;
using System.Collections.Generic;

namespace Opgaver_Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> p = new List<Person>();
            p.Add(new Person() { Id = 1, Navn = "Thomas" });
            p.Add(new Person() { Id = 2, Navn = "Mikkel" });
            p.Add(new Person() { Id = 3, Navn = "Hans" });

            p.ForEach(i => Console.WriteLine(i.Id + " " + i.Navn));

            Dictionary<int, string> p1 = new Dictionary<int, string>();

            p1.Add(1, "Mads");
            p1.Add(2, "Erik");
            p1.Add(3, "Knud");


            var x = p[1];
            Console.WriteLine(x.Navn);



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
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
