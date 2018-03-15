using System;
using NLog;
namespace Opgaver_TryCatchNLog
{
    class Program
    {

        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {

            log.Debug("Nu kaldes test1");
            test1(1, 4);
            log.Debug("Test1 er færdig");

            log.Debug("Nu kaldes test2");
            test2();
            log.Debug("Test2 er færdig");




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static void test1(int i, int x)
        {
            log.Trace($"Enter i , x {i}, {x}");
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
            log.Trace("Exit");
        }

        static void test2()
        {
            log.Trace("Enter");
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {

                log.Error(ex);
            }
            log.Trace("Exit");
        }
    }
}
