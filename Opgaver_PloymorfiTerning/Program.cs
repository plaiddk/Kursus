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
        private int _værdi;

        public int Værdi
        {
            get
            {
               
                return _værdi;
            }
            set
            {
                ;
                if (value < 0 || value > 6)
                {

                    this._værdi = 1;
                    Console.WriteLine("Værdien er ugyldig og sættes derfor til " + this._værdi);
                }
                else
                {
                    _værdi = value;
                    Console.WriteLine("Værdien er gyldig og den sættes derfor til " + _værdi);
                }
            }
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public virtual void Skriv()
        {
            Console.WriteLine("[" + this._værdi + "]");
        }

        public Terning()
        {
            Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

        //Kører igennem denne første gang og kun 1 gang
        //static Terning()
        //{
        //    rnd = new Random();
        //}
    }

    public class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            if (Værdi == 3)
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
            if (Værdi == 5)
            { return true; }
            else
            { return false; }
        }

        public LudoTerning() : base()
        {

        }

        public LudoTerning(int værdi) : base(værdi)

        {

        }

        public override void Skriv()
        {
            Console.WriteLine("Dette er en ludoterning");
            switch (this.Værdi)
            {
                case 3:
                    Console.WriteLine("[G]");
                    break;
                case 5:
                    Console.WriteLine("[*]");
                    break;
                default:
                    Console.WriteLine("["+this.Værdi+"]");
                    break;
            }
            Console.WriteLine("Dette er en ludoterning");
        }
    }
}
