using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_Egenskaber
{
    public class Person
    {
        public string Fornavn { get; set; }


        private string _efternavn;

        public string Efternavn
        {
            get { return this._efternavn; }
            set
            {
                if (value.Length <= 3)
                { this._efternavn = ""; }
                else
                {
                    this._efternavn = value;
                }
            }
        }

        public string FuldNavn()
        {
            return Fornavn + " " + Efternavn;
        }


    }

}
