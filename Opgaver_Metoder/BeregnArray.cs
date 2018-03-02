using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_Metoder
{
    class BeregnArray
    {
        public Retur BeregnOgSorterArray(int[] penge)
        {
            Retur r;
            r.sum = 0;

            System.Array.Sort(penge);
            for (int i = 0; i < penge.Length; i++)
            {
                r.sum += penge[i];

            }
            r.gns = r.sum / penge.Length;


            //foreach (var item in penge)
            //{
            //    r.sum += item;

            //}
            //r.gns = r.sum / penge.Length;

            return r;

        }
    }
}
