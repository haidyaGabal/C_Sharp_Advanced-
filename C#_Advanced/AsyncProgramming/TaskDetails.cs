using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.AsyncProgramming
{
    public class TaskDetails
    {
        public async Task RUN()
        {
            //excute other work until task ic compleated without wait Dowork func
            //if use await to task not excute operation after task until finish this operation

            //Task.Run() returns a Task can use await 
            //this task use threadingpool
            await Task.Run(() => DoWork(1));

            //this task not use any thread
            //when use await to ReadFromDatabase2 give me error
            //because can not use await with void

            //but when use with ReadFromDatabase is work
            //because return task;
            // await ReadFromDatabase2();
            await ReadFromDatabase();
            Console.WriteLine("other work");

            // when task create new thread 
            //when you method take longtime
            //You give the scheduler a hint that this is a long-running operation.
            //and you decided that
            //like
            await Task.Factory.StartNew(() =>
            {
                Console.WriteLine("task create a new thread");
            },TaskCreationOptions.LongRunning);

            // Task.Factory use threadpool
            //but Task.Factory.StartNew() use TaskScheduler 
            //TaskScheduler this decided what behavior do
            //LongRunning is a hint, not a command to create a new thread.
            //this can create new thread , threadpool or custom TaskScheduler based on behavior

            ///Does TaskCreationOptions.LongRunning always create a new thread?

            ///No.It depends on the TaskScheduler.
            ///The default TaskScheduler usually creates a dedicated thread for this option,
            ///but custom schedulers may behave differently.



        }


        private void DoWork(int taskId)
        {
            Console.WriteLine($"Task {taskId} is starting");
            Thread.Sleep(2000);
            Console.WriteLine($"Task {taskId} is Completed");
        }
        private async Task ReadFromDatabase()
        {
            Console.WriteLine("Start reading database");

            await Task.Delay(2000);

            Console.WriteLine("End reading database");
        }
        private  void ReadFromDatabase2()
        {
            Console.WriteLine("Start reading database");

            Thread.Sleep(5000);

            Console.WriteLine("End reading database");
        }


    }
}
