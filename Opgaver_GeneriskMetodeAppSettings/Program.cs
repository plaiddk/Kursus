using System;

namespace Opgaver_GeneriskMetodeAppSettings
{
    class Program
    {
        static void Main(string[] args)
        {


            string ip = GetAppSettings("ip", "127.1.1.0");
            string maxrecod = GetAppSettingGeneric("maxxrecords", "Forkert værdi");

            Console.WriteLine(ip);

            Console.WriteLine(maxrecod);




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static string GetAppSettings(string key, string defaultValue)
        {
            string v = System.Configuration.ConfigurationManager.AppSettings[key];
            if (v == null)
                return defaultValue;
            return v;
        }
       
        static T GetAppSettingGeneric<T>(string key, T defaultValue)
        {
            string v = System.Configuration.ConfigurationManager.AppSettings[key];
            if (v == null)
                return defaultValue;
            return (T)Convert.ChangeType(v, typeof(T));
        }
          
    }
}
