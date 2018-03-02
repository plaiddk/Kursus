using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_Metoder
{
    class Overload
    {

        public int Sammekald(int a, int b)
        {
            return a + b;
        }

        public int Sammekald(int a, int b, int c)
        {

            int res10 = Sammekald(1, 2);

            return a + b + c + res10;
        }



        public int Beregn(int a, int b)
        {
            return a + b;
        }

        public int Beregn(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Beregn(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
}
