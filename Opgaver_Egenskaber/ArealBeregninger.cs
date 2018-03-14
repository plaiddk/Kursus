using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_Egenskaber
{
    static class ArealBeregninger
    {
        public static double BeregnArealFirkant(double højde, double bredde)
        {
            return højde * bredde;

        }

        public static double BeregnArealCirkel(double radius)
        {
            return Math.Pow(radius, 2) * System.Math.PI;
        }

    }
}
