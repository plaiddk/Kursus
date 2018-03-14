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
        private int _v�rdi;

        public int V�rdi
        {
            get {
                Console.WriteLine("Der afl�ses en v�rdi" + this._v�rdi);
                return _v�rdi; }
            set {
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

        public void Skriv()
        {
            Console.WriteLine("["+this._v�rdi+"]");
        }

        public Terning()
        {
            Ryst();
        }

        public Terning(int v�rdi)
        {
            this.V�rdi = v�rdi;
        }
    }

    public class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            if(V�rdi == 3)
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
            if(V�rdi ==5)
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
    }
}
