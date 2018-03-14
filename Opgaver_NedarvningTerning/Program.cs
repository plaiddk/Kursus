using System;

namespace Opgaver_NedarvningTerning
{
    class Program
    {
        static void Main(string[] args)
        {


            Terning t = new Terning();
            t.Skriv();
            t.Ryst();
            t.Skriv();

            //LudoTerning l = new LudoTerning(5);
            //Console.WriteLine(l.ErGlobus());




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
            get {
                Console.WriteLine("Der aflæses en værdi" + this._værdi);
                return _værdi; }
            set {
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

        public void Skriv()
        {
            Console.WriteLine("["+this._værdi+"]");
        }

        public Terning()
        {
            Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }
    }

    public class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            if(Værdi == 3)
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
            if(Værdi ==5)
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
    }
}
