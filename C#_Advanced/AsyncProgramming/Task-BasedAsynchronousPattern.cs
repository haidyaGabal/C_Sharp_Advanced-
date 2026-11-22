
using System;
using System.Threading;
using System.Threading.Tasks;

namespace C__Advanced.AsyncProgramming
{
    internal class Task_BasedAsynchronousPattern
    {
        // 1. Return Task
        public async Task SaveDataAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Data saved.");
        }

        // 2. Return Task<TResult>
        public async Task<string> GetUserNameAsync()
        {
            await Task.Delay(1000);
            return "Haidy";
        }

        // 3. Async operation
        public async Task DownloadDataAsync()
        {
            Console.WriteLine("Downloading...");

            await Task.Delay(2000);

            Console.WriteLine("Download completed.");
        }

        // 4. Report progress using IProgress<T>
        public async Task DownloadAsync(IProgress<int> progress)
        {
            for (int i = 1; i <= 5; i++)
            {
                await Task.Delay(1000);

                progress?.Report(i * 20);
            }
        }

        // 5. Support cancellation using CancellationToken
        public async Task DownloadWithCancellationAsync(
            CancellationToken cancellationToken)
        {
            Console.WriteLine("Download started...");

            for (int i = 1; i <= 5; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                await Task.Delay(1000, cancellationToken);

                Console.WriteLine($"Downloaded: {i * 20}%");
            }

            Console.WriteLine("Download completed.");
        }
    }
}
