using System;
using Newtonsoft.Json;
namespace Opgaver_Repository
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Tester PersonRespositoryMock");
            PersonRepositoryMock rep1 = new PersonRepositoryMock();

            foreach (var item in rep1.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.DateOfBirth);
            }

            Person p1 = rep1.Get(1);
            Console.WriteLine(p1.Id + " " +p1.Name+ " " +p1.DateOfBirth);
            Console.WriteLine();
            Console.WriteLine("Tester PersonRespositoryJson");



            PersonRespositoryJson rep2 = new PersonRespositoryJson(@"x:\marx.json");
            foreach (var item in rep2.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.DateOfBirth);
            }

            Person p2 = rep2.Get(1);
            Console.WriteLine(p2.Id + " " + p2.Name + " " + p2.DateOfBirth);

            Console.WriteLine();
            Console.WriteLine("Tester interface IPersonRespository");

            IPersonRepository rep3;

            //rep3 = new PersonRepositoryMock();
            rep3 = new PersonRespositoryJson(@"x:\marx.json");

            foreach (var item in rep3.GetAll())
            {
                Console.WriteLine(item.Id +  " " + item.Name + " " + item.DateOfBirth);
            }


            Console.WriteLine();
            Console.WriteLine("Tester generator");
            IPersonRepository rep4 = PersonRespositoryGenerator.GetPersonRepository(@"x:\marx.json");
            foreach (var item in rep4.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.DateOfBirth);
            }

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
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public class PersonRepositoryMock : IPersonRepository
    {
        public Person Get(int id)
        {
            return new Person() { Id = 1, Name = "#1", DateOfBirth = new DateTime(2000, 1, 1) };
        }
          public Person[] GetAll()
        {
            Person[] p = new Person[2];
            p[0] = new Person() { Id = 1, Name = "#1", DateOfBirth = new DateTime(2000,10,2) };
            p[1] = new Person() { Id = 2, Name = "#2", DateOfBirth = new DateTime(2000,10,2) };
            return p;
        }
    }

    public class PersonRespositoryJson : IPersonRepository
    {
        private string filename;
        public PersonRespositoryJson(string filename)
        {
            
            this.filename = filename;
        }
        public Person[] GetAll()
        {
            string json = System.IO.File.ReadAllText(filename);
            var lst = Newtonsoft.Json.JsonConvert.DeserializeObject(json, typeof(Person[])) as Person[];
            return lst;
        }

        public Person Get(int id)
        {
            var lst = GetAll();
            foreach (var item in lst)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            throw new ApplicationException("Person not found");
        }

     
    }

    public interface IPersonRepository
    {
        Person[] GetAll();
        Person Get(int id);

    }

    public static class PersonRespositoryGenerator
    {
        public static IPersonRepository GetPersonRepository(string filename = null)
        {
            string repository = System.Configuration.ConfigurationManager.AppSettings["PersonRepository"];
            switch(repository)
            {
                case "PersonRepositoryJson":
                    return new PersonRespositoryJson(filename);
                case "PersonRepositoryMock":
                    return new PersonRepositoryMock();
                default:
                    throw new ApplicationException("Repository not found in config");
            }
        }
    }
}
