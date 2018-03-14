using System;

namespace Opgaver_PolymorfiDyr
{
    class Program
    {
        static void Main(string[] args)
        {


            Dyr[] d = new Dyr[10];

            for (int i = 0; i < 10; i++)
            {
                d[i] = Dyr.TilfældigtDyr();

            }

            foreach (var item in d)
            {
                item.SigNoget();

            }

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Dyr
    {
        private static System.Random rnd = new System.Random();
        public string navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder; " + this.navn);
        }

        public static Dyr TilfældigtDyr()
        {
            string sti = @"X:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);

            int x = rnd.Next(0, navne.Length);
            if(x % 2 == 0 )
            {
                return new Hund() { navn = navne[x] };

            }
            else
            {
                return new Kat() { navn = navne[x] };
            }
        }

    }

    public class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder: " +this.navn);
        }
       
    }

    public class Kat : Dyr

    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder: " + this.navn);
        }
        
    }
}
