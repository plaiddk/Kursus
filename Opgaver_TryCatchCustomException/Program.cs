using System;

namespace Opgaver_TryCatchCustomException
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                StockItem s = new StockItem(-1);
            }

            catch (StockItemException ex)
            {
                Console.WriteLine("StockItem Error");
                Console.WriteLine(ex);
            }

            catch(Exception e)
            {
                Console.WriteLine("Generel Error");
                Console.WriteLine(e);
            }


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class StockItem
    {
        public int Id { get; set; }

        public StockItem(int værdi)
        {
            if (værdi < 0)
                throw new StockItemException("Wrong id " + værdi);
            this.Id = værdi;
        }

    }

    public class StockItemException : Exception
    {
        public StockItemException()
        {

        }

        public StockItemException(string message) : base(message)
                {

        }

    }
}
