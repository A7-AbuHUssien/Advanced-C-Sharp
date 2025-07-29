

using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static Stopwatch ConcatinationStrings(int iteration)
    {
        string result = "";
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < iteration; i++)
        {
            result += "a";
        }
        stopwatch.Stop();
        return stopwatch;
    }

    static Stopwatch ConcatinationStringBuilder(int iteration)
    {
        StringBuilder result = new StringBuilder();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < iteration; i++)
        {
            result.Append("a");
        }
        stopwatch.Stop();
        return stopwatch;
    }

    static void Main()
    {
        int iteration = 500000;

        Stopwatch stringTime = ConcatinationStrings(iteration);
        Stopwatch sbTime = ConcatinationStringBuilder(iteration);

        Console.WriteLine($"String concat time: {stringTime.ElapsedMilliseconds} ms");
        Console.WriteLine($"StringBuilder time: {sbTime.ElapsedMilliseconds} ms");
    }
}
