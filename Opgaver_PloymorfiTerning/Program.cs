using System;

namespace Opgaver_PloymorfiTerning
{
    class Program
    {
        static void Main(string[] args)
        {


            Terning t = new Terning();
            t.Skriv();
            t.Ryst();
            t.Skriv();

            Console.WriteLine();
            Console.WriteLine();

            LudoTerning lt = new LudoTerning(5);
            lt.Skriv();
            lt.Ryst();
            lt.Skriv();

            Console.WriteLine();
            Console.WriteLine();


            Terning[] lt1 = new Terning[5];
            lt1[0] = new Terning();
            lt1[1] = new Terning();
            lt1[2] = new LudoTerning();
            lt1[3] = new LudoTerning();
            lt1[4] = new Terning();

            foreach (var item in lt1)
            {
                item.Skriv();
            }


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Terning
    {
        private static System.Random rnd = new System.Random();
        private int _v�rdi;

        public int V�rdi
        {
            get
            {
               
                return _v�rdi;
            }
            set
            {
                ;
                if (value < 0 || value > 6)
                {

                    this._v�rdi = 1;
                    Console.WriteLine("V�rdien er ugyldig og s�ttes derfor til " + this._v�rdi);
                }
                else
                {
                    _v�rdi = value;
                    Console.WriteLine("V�rdien er gyldig og den s�ttes derfor til " + _v�rdi);
                }
            }
        }

        public void Ryst()
        {
            this.V�rdi = rnd.Next(1, 7);
        }

        public virtual void Skriv()
        {
            Console.WriteLine("[" + this._v�rdi + "]");
        }

        public Terning()
        {
            Ryst();
        }

        public Terning(int v�rdi)
        {
            this.V�rdi = v�rdi;
        }

        //K�rer igennem denne f�rste gang og kun 1 gang
        //static Terning()
        //{
        //    rnd = new Random();
        //}
    }

    public class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            if (V�rdi == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ErStjerne()
        {
            if (V�rdi == 5)
            { return true; }
            else
            { return false; }
        }

        public LudoTerning() : base()
        {

        }

        public LudoTerning(int v�rdi) : base(v�rdi)

        {

        }

        public override void Skriv()
        {
            Console.WriteLine("Dette er en ludoterning");
            switch (this.V�rdi)
            {
                case 3:
                    Console.WriteLine("[G]");
                    break;
                case 5:
                    Console.WriteLine("[*]");
                    break;
                default:
                    Console.WriteLine("["+this.V�rdi+"]");
                    break;
            }
            Console.WriteLine("Dette er en ludoterning");
        }
    }
}
