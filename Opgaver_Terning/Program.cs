using System;

namespace Opgaver_Terning
{
    class Program
    {
        static void Main(string[] args)
        {

            //Simple terning som leger med heap referencer
            Terning t = new Terning();
            Console.WriteLine(t.Værdi); // 1

            Terning t2 = new Terning(4); //4
            Console.WriteLine(t2.Værdi);

            t2 = t; //Sættes til 1

            Console.WriteLine(t.Værdi); // den er nu 1
            Console.WriteLine(t2.Værdi); //Dennne er sat til t1 nu er værdi 1

            Console.WriteLine("Værdien ændres manuelt på t1");
            t.Værdi = 2;
            Console.WriteLine(t.Værdi); //Da de peger på de samme bliver den 2
            Console.WriteLine(t2.Værdi); // Da de peger på den samme bliver den 2

            Console.WriteLine("Nu ændres værdi på t2");
            t2.Værdi = 5;

            Console.WriteLine(t.Værdi); //Da de peger på den samme bliver den nu 5
            Console.WriteLine(t2.Værdi);//Da de peger på den samme bliver den nu 5 **NOTE Da det er reference baseret er det ligemeget om det er t1 eller t2 der ændres. De peger stadig på den samme via referencen


            //Terning1 som gør forskellige ting ift om der er snyd eller ej

            Terning1 t4 = new Terning1();
            t4.Skriv();
            t4.Ryst();
            t4.Skriv();

            Terning1 t5 = new Terning1(true);

            t5.Skriv();
            t5.Ryst();
            t5.Skriv();



            Console.ReadKey();


        }
    }

    public class Terning
    {
        public int Værdi;

        public Terning()
        {
            this.Værdi = 1;
        }

        public Terning(int value)
        {
            this.Værdi = value;
        }
    }

    public class Terning1
    {
        public int Værdi;
        private bool snyd;
        private static Random rnd = new Random();

  

        public void Skriv()
        {
            Console.WriteLine("["+this.Værdi+"]");
        }

     
        public void Ryst()
        {
            if (snyd == false)
            {
                this.Værdi = rnd.Next(1, 7);
            }
            else
            {
                this.Værdi = 6;
            }
        }

        public Terning1()
        {
            this.Værdi = 1;
            this.snyd = false;
        }

        public Terning1(bool snyd)
        {
            this.Værdi = 1;
            this.snyd = snyd;
        }
    }
}
