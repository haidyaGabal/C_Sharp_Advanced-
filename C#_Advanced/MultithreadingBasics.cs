using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced
{
    /// <summary>
    /// i will use lock for thread this mean 
    /// lock does NOT make threads run one after another (sequentially).
    /// lock does NOT make one thread "end first" before another starts.
    /// </summary>
    public class MultithreadingBasics
    {
        private static object _lock=new object();

        public static void ProcessBatch1()
        {

            for (int i = 0; i < 1000; i++)
            {
                lock (_lock)
            {
               
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }
          
        }

        public static void ProcessBatch2()
        {

            for (int i = 1001; i < 2000; i++)
            {
                lock (_lock)
            {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;

                }

            }
           
        }
    }
}
