using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_løkke
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 11; i++)
            {
               
                for (int j =1; j < 11; j++)
                {
                     if (i * j >= 50)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.Write(i * j + "\t");
                }
                Console.Write("\n");

            }
            Console.ReadKey();
        }
    }
}
