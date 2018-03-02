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
            //Loop fra 1 til 11 - Da det er 10 tabellen vi skal bruge, så 0 skal selvfølgelig ikke med og 10 er max
            for (int i = 1; i < 11; i++)
            {
               //Gange dem op så vi får tabellen
                for (int j =1; j < 11; j++)
                {

                    //Hvis værdien er = eller over 50 så skriv gul tekst eller hvid
                     if (i * j >= 50)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        //Ved afslutning af hver række horisontal lav et mellemrum med tabulartor tegnet
                        Console.Write(i * j + "\t");
                }

                //Ved afslutning af hver række ned af 1 til 10 afslut med newline
                Console.Write("\n");

            }
            Console.ReadKey();
        }
    }
}
