using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C__Advanced.Multithreading
{
    public class RaceConditioning
    {
        private int count = 0;
        private readonly object locks = new object();

        public void Threads()
        {
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);

            t1.Start();
            t2.Start();

      

        }
        /// <summary>
        /// Race Condition:
        /// Occurs when multiple threads access shared data concurrently,
        /// and at least one thread modifies that data.
        /// The execution order can affect the final result,
        /// potentially causing unexpected or incorrect behavior.
        /// </summary>

        public void Increment()
        {
            ///lock : solve this problem (race Condition)
            lock (locks)
            {
                for (int i = 0; i < 100000; i++)
                {
                    count++;
                }
                Console.WriteLine("Final Count: " + count);

              

            }

           
        }

        
    }
}
