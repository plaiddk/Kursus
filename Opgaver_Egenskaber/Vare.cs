using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_Egenskaber
{
    public class Vare
    {
        private string navn;

        public string Navn
        {
            get
            {
                Console.WriteLine("Der aflæses et navn");
                return navn;
            }
            set
            {
                Console.WriteLine("Der sættes et navn");
                navn = value;
            }
        }

        private double pris;

        public double Pris
        {
            get
            {
                Console.WriteLine("Der aflæses en pris");
                return pris;
            }
            set
            {
                Console.WriteLine("Der sættes en pris");
                pris = value;
            }
        }

        public double PrisMedMoms()
        {
            return this.pris * 1.25;
        }

        public Vare()
        {

        }

        public Vare(double pris, string navn)
        {
            this.pris = pris;
            this.navn = navn;
        }

    }
}
