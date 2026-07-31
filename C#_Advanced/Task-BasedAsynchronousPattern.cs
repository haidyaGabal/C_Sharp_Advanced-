using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced
{
    internal class Task_BasedAsynchronousPattern
    {
        // Return a Task or Task<TResult>
        public async Task SaveDataAsync()
        {
            await Task.Delay(1000);
        }

        public async Task<string> GetUserNameAsync()
        {
            await Task.Delay(1000);
            return "Haidy";
        }

        //Use async / await for natural consumption
        public async Task DownloadDataAsync()
        {
            Console.WriteLine("Downloading...");

            // Simulate a 2-second operation
            await Task.Delay(2000);

            Console.WriteLine("Download completed.");
        }

        //Follow naming convention MethodNameAsync

        //Report progress via IProgress<T> if needed

        //Support cancellation via CancellationToken
    }
}
