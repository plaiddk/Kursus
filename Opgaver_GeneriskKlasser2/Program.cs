using System;
using System.Collections.Generic;

namespace Opgaver_GeneriskKlasser2
{
    class Program
    {
        static void Main(string[] args)
        {


            YatzyTerning y = new YatzyTerning();
            Console.WriteLine(y);

            LudoTerning l = new LudoTerning();
            Console.WriteLine(l);

            Console.WriteLine();
            Console.WriteLine();

            //Bæger b = new Bæger();
            //b.Tilføj(new YatzyTerning());
            //b.Tilføj(new LudoTerning());

            //LudoTerning e = b.Terninger()[1] as LudoTerning;
            //Console.WriteLine(e.ErGlobus());

            Console.WriteLine();
            Console.WriteLine();

            Bæger<LudoTerning> b1 = new Bæger<LudoTerning>();

            b1.Tilføj(new LudoTerning());
            b1.Tilføj(new LudoTerning());

            LudoTerning e1 = b1.Terninger()[1];
            Console.WriteLine(e1.ErGlobus());



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            } 
        }
    }

    public abstract class Terning
    {
        private static System.Random rnd = new Random();
        public int Værdi { get; private set; }
        public void Ryst()
        {
            Værdi = rnd.Next(1, 7);
        }
        public override string ToString()
        {
            return "[" + this.Værdi + "]";
        }
    }

    public class YatzyTerning : Terning
    {
        public YatzyTerning()
        {
            this.Ryst();
        }
    }

    public class LudoTerning : Terning
    {
        public override string ToString()
        {
            if (this.ErStjerne())
                return "[S]";
            if (this.ErGlobus())
                return "[G]";
            return base.ToString();
        }

        public LudoTerning()
        {
            this.Ryst();
        }

        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }
        public bool ErGlobus()
        {
            return this.Værdi == 3;
        }
    }

    public class Bæger<T> where T:Terning
    {
        private List<T> lst = new List<T>();
        public void Tilføj(T d)
        {
            lst.Add(d);
        }
        public List<T> Terninger()
        {
            return lst;
        }
    }

}
