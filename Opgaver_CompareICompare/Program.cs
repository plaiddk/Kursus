using System;

namespace Opgaver_CompareICompare
{
    class Program
    {
        static void Main(string[] args)
        {


            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };

            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }
            
            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Hund : IComparable  
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {

            Hund h = obj as Hund;
            if (h.Alder > this.Alder)
                return -1;
            if (h.Alder < this.Alder)
                return 1;
            else
                return 0;
        }
    }
}
