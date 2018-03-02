using System;

namespace Opgaver_Metoder
{
    class Program
    {
        static void Main(string[] args)
        {

            //Små metoder
            Metoder m = new Metoder(); //klasse

            int res  = m.LægSammen(2, 2);
            Console.WriteLine("lægsammen metode: " + res);


            double res2 = m.BeregnAntal(50);
            Console.WriteLine("Beregn antal metode: " + res2);


            m.Udskriv();

            m.Udskriv("Metode udskriv");

            double res3 = m.BeregnMoms(150.00);
            Console.WriteLine("Dette er metode beregnmoms, uden indtastet moms: "+ res3);
            double res4 = m.BeregnMoms(150.00, 0.20);         
            Console.WriteLine("Dette er metode beregnmoms, med moms: "+ res4);


            int[] løn = { 1000, 4000, 5000 };

            double res5 = m.gns(løn);

            Console.WriteLine(res5);
           


            //Overload
            Overload o = new Overload(); //klasse

            int be1 = o.Beregn(1, 2);
            int be2 = o.Beregn(1, 2, 3);
            int be3 = o.Beregn(1, 2, 4, 5);

            Console.WriteLine(be1);
            Console.WriteLine(be2);
            Console.WriteLine(be3);

            int be5 = o.Sammekald(1, 2, 3);
            Console.WriteLine(be5);



            //Beregn Array
            BeregnArray b = new BeregnArray(); //klasse

            int[] test = { 10,7,6,3,1,50,3 };
            var resb = b.BeregnOgSorterArray(test);
            Console.WriteLine(resb.gns);
            Console.WriteLine(resb.sum);

            Console.ReadKey();
        }


    }

   

    public struct Retur
    {
       public double sum;
       public  double gns;
    }

   
 
  
}
