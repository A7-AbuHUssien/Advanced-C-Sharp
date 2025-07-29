using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelExample
{
    internal class Program
    {
        static List<string> urls = new List<string>
        {
            "https://www.cnn.com",
            "https://www.amazon.com",
            "https://www.programmingadvices.com",
            "https://www.Facebook.com",
            "https://www.google.com",
          

        };
        static void DownloadContent(string url)
        {
            string content;


            using (WebClient client = new WebClient())
            {
                // Simulate some work by adding a delay
                Thread.Sleep(100);


                // Download the content of the web page
                content = client.DownloadString(url);
            }


            Console.WriteLine($"{url}: {content.Length} characters downloaded");
        }
        static void Main(string[] args)
        {
            

            Parallel.ForEach(urls,url =>
            {
               DownloadContent(url);
            });

            Console.WriteLine("All Completed");
            Console.ReadKey();

            
        }
    }
}
