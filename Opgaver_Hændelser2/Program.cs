using System;

namespace Opgaver_Hændelser2
{
    class Program
    {
        static void Main(string[] args)
        {


            Kunde k = new Kunde() { KreditMax = -500 };
            k.KreditOverskredet += (s, e) => { Console.WriteLine("Kredit overskredet"); };
            k.Køb(200);
            k.Køb(1300);
            




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Kunde
    {
        public event EventHandler KreditOverskredet;
        public string Navn { get; set; }
        public int Saldo { get; set; }

        public int KreditMax { get; set; }

        public void Køb(int værdi)
        {
            Console.WriteLine("kunde {0} køber for {1}",Navn,værdi);
            this.Saldo -= værdi;
            if(Saldo < KreditMax)
            {
                KreditOverskredet(this,new EventArgs());
            }
        }
            
    }

    
}
