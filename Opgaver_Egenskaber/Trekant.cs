using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_Egenskaber
{
    public class Trekant
    {
        public int Grundlinje { get; private set; }

        public int Højde { get; private set; }

        public Trekant(int grund, int højde)
        {
            this.Grundlinje = grund;
            this.Højde = højde;
        }

        public double Areal
        {
            get
            {
                return Grundlinje * Højde * 1.25;
            }
        }

        public double ArealMetode()
        {
            return Grundlinje * Højde * 1.25;
        }

    }
}
