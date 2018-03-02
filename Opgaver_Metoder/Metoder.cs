using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_Metoder
{
    class Metoder
    {

        public int LægSammen(int a, int b)
        {
            return a + b;
        }

        public double BeregnAntal(int radius)
        {
            return radius * radius * System.Math.PI;

        }

        public void Udskriv()
        {
            Console.WriteLine();
        }

        public void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }

        public double BeregnMoms(double beløb, double momsPct = 0.25)
        {
            return beløb * momsPct;
        }

        public double gns(int[] månedsLøn)
        {
            double sum = 0;
            for (int i = 0; i < månedsLøn.Length; i++)
            {
                sum += månedsLøn[i];
            }
            return sum / månedsLøn.Length;
        }
    }
}
