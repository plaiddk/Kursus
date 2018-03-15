using System;

namespace Opgaver_DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                ITilf�ldighedsGenerator m = new Tilf�ldighedsGeneratorMock(1);
                Console.WriteLine(m.FindTalTilTerning());
                ITilf�ldighedsGenerator f = new Tilf�ldighedsGeneratorFramework();
                Console.WriteLine(f.FindTalTilTerning());
            }

            {
                Tilf�ldighedsGeneratorMock m = new Tilf�ldighedsGeneratorMock(1);
                Terning t1 = new Terning(m);
                Console.WriteLine(t1.V�rdi);

                Tilf�ldighedsGeneratorFramework f = new Tilf�ldighedsGeneratorFramework();
                Terning t2 = new Terning(f);
                Console.WriteLine(t2.V�rdi);
            }

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }

    public interface ITilf�ldighedsGenerator
    {
        int FindTalTilTerning();
    }

    public class Tilf�ldighedsGeneratorFramework : ITilf�ldighedsGenerator
    {
        private static System.Random rnd = new System.Random();

        public int FindTalTilTerning()
        {
            return rnd.Next(1, 7);
        }
    }

    public class Tilf�ldighedsGeneratorMock : ITilf�ldighedsGenerator
    {
        private int tal;
        public Tilf�ldighedsGeneratorMock(int tal)
        {
            this.tal = tal;
        }
        public int FindTalTilTerning()
        {
            return this.tal;
        }
    }

    class Terning
    {
        private ITilf�ldighedsGenerator generator;

        public int V�rdi { get; set; }

        public Terning(ITilf�ldighedsGenerator rnd)
        {
            generator = rnd;
            Ryst();
        }

        public void Ryst()
        {
            this.V�rdi = generator.FindTalTilTerning();
        }
    }

}
