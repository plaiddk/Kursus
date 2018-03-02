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
            p.F�dsels�r = 2002;

            Console.WriteLine(p.Fornavn + " " + p.Efternavn);

            //p.Fuldtnavn();
            var res = p.Fuldtnavn();
            Console.WriteLine(res);

            //p.Alder();
            var res2 = p.Alder();
            Console.WriteLine(res2);

            Person p1 = new Person("Thomas", "Jensen", 2002);

            Console.WriteLine(p1.Fornavn +" "+ p1.Efternavn + " er  " +p1.F�dsels�r + " gammel");

            Console.ReadKey();
        
        }
    }

    public class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int F�dsels�r;

        public string Fuldtnavn()
        {
            return Fornavn + " " + Efternavn;
        }

        public int Alder()
        {
            return DateTime.Now.Year - F�dsels�r;
        }

        //Default constructor - Eksekveres altid f�rst n�r man instancere en ny klasse med new
        public Person()
        {
            Console.WriteLine("nu starter vi");
            this.Fornavn = "";
            this.Efternavn = "";
        }

        //Custom constructor kan tage input variable
        public Person(string Fornavn, string Efternavn, int F�dsels�r)
        {
            this.Fornavn = Fornavn.ToUpper();
            this.Efternavn = Efternavn.ToUpper();
            this.F�dsels�r = DateTime.Now.Year - F�dsels�r;
        }
    }
}
