using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Common
{
    public class LoggingService
    {
        public static void WriteToFile(List<Object> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
                Console.WriteLine(item);
            }
        }

        public 


    }
}
