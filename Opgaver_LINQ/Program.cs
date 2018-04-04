using System;
using System.Linq;

namespace Opgaver_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            //1
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hent først 10 personer");
            Console.ResetColor();
            var p = new PersonNuGetPackage.PersonRepositoryRandom().GetPeople(10);

            foreach (var item in p)
            {
                Console.WriteLine(item.Name);
            }

            //2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sorter efter navn og udskriv navn");
            Console.ResetColor();
            var p1 = new PersonNuGetPackage.PersonRepositoryRandom().GetPeople(10);
            var res1 = p1.OrderBy(i => i.Name);
            foreach (var item in res1)
            {
                Console.WriteLine(item.Name);
            }

            //3
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sorter efter gend og navn og udskriv ");
            Console.ResetColor();
          
            var res2 = p1.OrderBy(i => i.Name).ThenBy(i => i.Gender);
            foreach (var item in res2)
            {
                Console.WriteLine(item.Name + " " + item.Gender);
            }

            //4
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Filtre og udskriv således personer med heigh > 170 vises");
            Console.ResetColor();
            var res3 = p1.Where(i => i.Height <170);
            foreach (var item in res3)
            {
                Console.WriteLine(item.Name + " " + item.Gender + " " + item.Height);
            }

            //5
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Filtre og udskriv hvor height <= 170 og ishealty = true");
            Console.ResetColor();
            var res4 = p1.Where(i => i.Height <= 170 && i.IsHealthy == true);
            foreach (var item in res4)
            {
                Console.WriteLine(item.Name + " " + item.Gender + " " + item.Height + " " + item.IsHealthy);
            }

            //6
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Grupper efter gender og udksriv hver gruppe");
            Console.ResetColor();
            var res5 = p1.GroupBy(i=>i.Gender);
            foreach (var item in res5)
            {
                Console.WriteLine(item.Key);

                foreach (var x in item )
                {
                    Console.WriteLine(x.Gender + " " + x.Name);
                }
            }

            //7
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sorter og udskriv navn - Men der skal kun retuerneres et anynomyt objeckt med navn og hiehght");
            Console.ResetColor();
            var res6 = p1.OrderBy(i => i.Name).Select(i=> new { Navn = i.Name, Højde = i.Height });

            foreach (var item in res6)
            {
                Console.WriteLine(item.Højde + " " + item.Navn);
            }

            //8
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Grupper og sorter efter hiehg således at der skabes grupper");
            Console.ResetColor();
            int[] interval = { 160, 170, 180, 190, 200, 210 };
            var res7 = p1.OrderBy(i => i.Height).GroupBy(x => interval.FirstOrDefault(z => z > x.Height));

            foreach (var item in res7)
            {
                Console.WriteLine(item.Key);

                foreach (var t in item)
                {
                    Console.WriteLine(t.Name + " " + t.Height);
                }
            }






            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
