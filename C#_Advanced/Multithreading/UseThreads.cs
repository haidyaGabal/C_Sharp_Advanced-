
using System;
using System.Diagnostics.Metrics;
using System.Threading;

namespace C__Advanced.Multithreading
{
    public class UseThreads
    {
        public void StartThreads()
        {
            //Pass the method PrintNumbers
            // pass one parameter 
            //this parameter must be object
            Thread thread1 = new Thread(PrintNumbers);
            Thread thread2 = new Thread(PrintLetters);

            thread1.Start();
            thread1.Join();

            //give parameter in start
            thread2.Start(2);

          //join
            //Main starts thread1.
             //Main starts thread2.
            //Main waits for thread1 to finish.
            //Main continues after thread1 completes.
           
        }

        private void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Number: {i}");
                Thread.Sleep(500);
            }
        }

        private void PrintLetters(object threadNumber)
        {
            for (char letter = 'A'; letter <= 'E'; letter++)
            {
                Console.WriteLine($"Letter: {letter}====={threadNumber}");
                Thread.Sleep(500);
            }
        }
    }
}
