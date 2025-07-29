using System;
using System.Net;
using System.Threading.Tasks;

namespace Asynchronous_Programming1
{
    internal class Program
    {
   
        static async Task Main()
        {
            Console.WriteLine("Starting Tasks....");
            Task task1 = DownloadandPrintAsync("http://www.amazon.com");
            Console.WriteLine("Task 1 Started ...");

            Task task2 = DownloadandPrintAsync("http://www.google.com");
            Console.WriteLine("Task 2 Started ...");

            Task task3 = DownloadandPrintAsync("http://www.Facebook.com");
            Console.WriteLine("Task 3 Started ...");

            DoOtherWork();

            await Task.WhenAll(task1, task2, task3);
            Console.WriteLine("All Downloaded ");


        }
        static async Task  DownloadandPrintAsync(string url)
        {
            string Content;
            using (WebClient client = new WebClient())
            {
                await Task.Delay(20000);
                Content = await client.DownloadStringTaskAsync(url);
            }
            Console.WriteLine($"{url}: {Content.Length} Characters Downloaded");
            
        }

        // Simulate doing some other work
        static void DoOtherWork()
        {
            Console.WriteLine("🛠️ Doing other work while downloading...");

            
        }
    }
}
