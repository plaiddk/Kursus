using System;

namespace Opgaver_Klasser
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
     

            p.Fornavn = "Thomas";
            p.Efternavn = "Jensen";
            p.Fødselsår = 2002;

            Console.WriteLine(p.Fornavn + " " + p.Efternavn);

            //p.Fuldtnavn();
            var res = p.Fuldtnavn();
            Console.WriteLine(res);

            //p.Alder();
            var res2 = p.Alder();
            Console.WriteLine(res2);

            Person p1 = new Person("Thomas", "Jensen", 2002);

            Console.WriteLine(p1.Fornavn +" "+ p1.Efternavn + " er  " +p1.Fødselsår + " gammel");

            Console.ReadKey();
        
        }
    }

    public class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public string Fuldtnavn()
        {
            return Fornavn + " " + Efternavn;
        }

        public int Alder()
        {
            return DateTime.Now.Year - Fødselsår;
        }

        //Default constructor - Eksekveres altid først når man instancere en ny klasse med new
        public Person()
        {
            Console.WriteLine("nu starter vi");
            this.Fornavn = "";
            this.Efternavn = "";
        }

        //Custom constructor kan tage input variable
        public Person(string Fornavn, string Efternavn, int Fødselsår)
        {
            this.Fornavn = Fornavn.ToUpper();
            this.Efternavn = Efternavn.ToUpper();
            this.Fødselsår = DateTime.Now.Year - Fødselsår;
        }
    }
}
