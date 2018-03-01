using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            HelTal();
            KommaTal();
            enums();
            Dato();
            Persons();

        }

        static void HelTal()
        {

            //Heltal
            Int32 i = 10;

            i++; // ligge et tal til
            i--; // trække et tal fra
            i += 20; //Ligge tallet oveni det forekommende

            Console.WriteLine(i);
            Console.ReadKey();
        }

        static void KommaTal()
        {
            double komma = 12.5;

            komma++; //ligge tal til
            komma--;
            komma *= 2; // Gange med det forekommende


            Console.WriteLine((double)komma);
            Console.ReadKey();
        }

        static void enums()
        {
            FilTyper ft = FilTyper.csv;
            Console.WriteLine((int)ft);
            Console.ReadKey();

        }

        static void Dato()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("ddMMyy"));
            Console.WriteLine(dt.ToString("ddd MM-yyyy"));
            Console.WriteLine(dt.ToString("dd MMM yyyy"));

            Console.ReadKey();
        }

        static void Persons()
        {
            Person p1 = new Person();
            p1.Navn = "Mikkel";
            p1.id = 1;

            Console.WriteLine(p1.Navn);
            Console.ReadKey();
        }
       
    }
    public enum FilTyper
    {
       csv,
       pdf,
       txt,
    }

    public struct Person
    {
        public int id;
        public string Navn;
    }
}
    
    


