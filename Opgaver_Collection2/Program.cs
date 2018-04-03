using System;
using System.Collections.Generic;

namespace Opgaver_Collection2
{
    class Program
    {
        static void Main(string[] args)
        {


            Bunke b = new Bunke();
            b.Tilf�jKort(new Kort() { Kul�r = "spar", V�rdi = 2 });
            b.Tilf�jKort(new Kort() { Kul�r = "Hjerter", V�rdi = 14 });
            b.Tilf�jKort(new Kort() { Kul�r = "Ruder", V�rdi = 3 });
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();
            b.Vis();



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Kort
    {
        public string Kul�r { get; set; }
        public int V�rdi { get; set; }

        public override string ToString()
        {
            return this.Kul�r + " " + this.V�rdi;
        }
    }

    public class Bunke
    {
        //Last in first out
        private Stack<Kort> s = new Stack<Kort>();
        public Kort FjernKort()
        {
            if (s.Count > 0)
                return s.Pop();
            return null;
      

        }

        public void Tilf�jKort(Kort b)
        {
            s.Push(b);

        }

        public void    Vis()
        {

            foreach (var item in s)
            {
                Console.WriteLine(item);

            }
        }


    }
}
