
using System;
using System.Net;
using System.Security.Policy;
using System.Threading;

namespace HospitalSystem
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Starting Threads ...");
            Thread thread1 = new Thread(() => DownloadAndPrint("http://www.cnn.com"));
            thread1.Start();
            Console.WriteLine("Thread 1 Started ....");

            Thread thread2 = new Thread(() => DownloadAndPrint("http://www.amazon.com"));
            thread2.Start();
            Console.WriteLine("Thread 2 Started ....");

            Thread thread3 = new Thread(() => DownloadAndPrint("http://www.programmingadvices.com"));
            thread3.Start();
            Console.WriteLine("Thread 3 Started ....");

            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("\t\t\t\t\t\t\t\tAll Downloaded");
            
        }

        static void DownloadAndPrint(string url)
        {
            string Content;
            using (WebClient webClient = new WebClient())
            {
                Thread.Sleep(100);
                Content = webClient.DownloadString(url);
            }
            Console.WriteLine($"{url}:{Content.Length}Characters Downloaded");
        }
    }
}
