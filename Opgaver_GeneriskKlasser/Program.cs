using System;
using System.Collections.Generic;

namespace Opgaver_GeneriskKlasser
{
    class Program
    {
        static void Main(string[] args)
        {


            Personer1 p1 = new Personer1();
            p1.Tilføj(new Instruktør() { Navn = "thomas",KursistId = 1, InstruktørId = 3 });
            p1.Skriv();


            Personer2<Instruktør> p2 = new Personer2<Instruktør>();
            p2.Tilføj(new Instruktør() { Navn = "thomas", KursistId = 2, InstruktørId = 3 });

            Personer3<Instruktør> p3 = new Personer3<Instruktør>();
            p3.Tilføj(new Instruktør() { Navn = "thomas", KursistId = 3, InstruktørId = 3 });

            Console.WriteLine();







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
        public string Navn { get; set; }

        public int KursistId { get; set; }


        public int InstruktørId { get; set; }

   

    }
    public class Instruktør : Person  {
        
    }

    public class Kursist : Person {  }

    public class Personer1
    {
        
        private List<Person> personer = new List<Person>();

        public void Tilføj(Person person)
        {
            personer.Add(person);
        }

        public void Skriv()
        {
            foreach (var item in personer)
            {
                Console.WriteLine(item.Navn + " " + item.KursistId + " " +item.InstruktørId);
            }
        }
    }

    public class Personer2<T>
    {
        private List<T> personer = new List<T>();
        public void Tilføj(T person)
        {
            personer.Add(person);

       }
    }

    public class Personer3<T> where T:Person
    {
        private List<T> personer = new List<T>();
        public void Tilføj(T person)
        {
            personer.Add(person);
        }
    }
}
