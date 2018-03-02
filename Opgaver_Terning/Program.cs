using System;

namespace Opgaver_Terning
{
    class Program
    {
        static void Main(string[] args)
        {

            //Simple terning som leger med heap referencer
            Terning t = new Terning();
            Console.WriteLine(t.V�rdi); // 1

            Terning t2 = new Terning(4); //4
            Console.WriteLine(t2.V�rdi);

            t2 = t; //S�ttes til 1

            Console.WriteLine(t.V�rdi); // den er nu 1
            Console.WriteLine(t2.V�rdi); //Dennne er sat til t1 nu er v�rdi 1

            Console.WriteLine("V�rdien �ndres manuelt p� t1");
            t.V�rdi = 2;
            Console.WriteLine(t.V�rdi); //Da de peger p� de samme bliver den 2
            Console.WriteLine(t2.V�rdi); // Da de peger p� den samme bliver den 2

            Console.WriteLine("Nu �ndres v�rdi p� t2");
            t2.V�rdi = 5;

            Console.WriteLine(t.V�rdi); //Da de peger p� den samme bliver den nu 5
            Console.WriteLine(t2.V�rdi);//Da de peger p� den samme bliver den nu 5 **NOTE Da det er reference baseret er det ligemeget om det er t1 eller t2 der �ndres. De peger stadig p� den samme via referencen


            //Terning1 som g�r forskellige ting ift om der er snyd eller ej

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
        public int V�rdi;

        public Terning()
        {
            this.V�rdi = 1;
        }

        public Terning(int value)
        {
            this.V�rdi = value;
        }
    }

    public class Terning1
    {
        public int V�rdi;
        private bool snyd;
        private static Random rnd = new Random();

  

        public void Skriv()
        {
            Console.WriteLine("["+this.V�rdi+"]");
        }

     
        public void Ryst()
        {
            if (snyd == false)
            {
                this.V�rdi = rnd.Next(1, 7);
            }
            else
            {
                this.V�rdi = 6;
            }
        }

        public Terning1()
        {
            this.V�rdi = 1;
            this.snyd = false;
        }

        public Terning1(bool snyd)
        {
            this.V�rdi = 1;
            this.snyd = snyd;
        }
    }
}
