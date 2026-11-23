
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace C__Advanced.AsyncProgramming
{
    public class ParllelProgramming
    {
        // 1. Parallel.For
        public void UseParallelFor()
        {
            Parallel.For(1, 20, i =>
            {
                Console.WriteLine($"Processing {i}  ==> {Thread.CurrentThread.ManagedThreadId}");
            });
        }

        // 2. Parallel.ForEach
        public void UseParallelForEach()
        {
            List<string> names = new List<string>
            {
                "Haidy", "Ahmed", "Mohamed", "Ali"
            };

            Parallel.ForEach(names, name =>
            {
                Console.WriteLine($"Processing {name}");
            });
        }

        // 3. Parallel.Invoke
        public void UseParallelInvoke()
        {
            Parallel.Invoke(
                () => DoWork(1),
                () => DoWork(2),
                () => DoWork(3)
            );

            Console.WriteLine("All operations completed");
        }

        private void DoWork(int id)
        {
            Console.WriteLine($"Task {id} started");

            Thread.Sleep(2000);

            Console.WriteLine($"Task {id} completed");
        }
    }
}
