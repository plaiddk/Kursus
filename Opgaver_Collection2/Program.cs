using System;
using System.Collections.Generic;

namespace Opgaver_Collection2
{
    class Program
    {
        static void Main(string[] args)
        {


            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
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
        public string Kulør { get; set; }
        public int Værdi { get; set; }

        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
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

        public void TilføjKort(Kort b)
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
