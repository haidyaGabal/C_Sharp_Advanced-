using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Multithreading
{
    public class UseThreadPool
    {
        public void StartThreadPool()
        {
            // Queue work items to the ThreadPool
            ThreadPool.QueueUserWorkItem(DoWork, "Task 1");
            ThreadPool.QueueUserWorkItem(DoWork, "Task 2");
            ThreadPool.QueueUserWorkItem(DoWork, "Task 3");
            Thread t1 = new Thread(DoWork);
            Thread t2 = new Thread(DoWork);
            Thread t3 = new Thread(DoWork);
            t1.Start();
            t2.Start();
            t3.Start();
        }

        private void DoWork(object? state)
        {
            Console.WriteLine(
                $"{state} - Thread ID: {Thread.CurrentThread.ManagedThreadId}"
            );

            Thread.Sleep(1000);

            Console.WriteLine($"{state} completed!");
        }
    }
}
