using System;
using System.Diagnostics;
using System.Text;

namespace BenchmarkDotNetExample.StopwatchCalculating
{
    class Program
    {
        static int count = 10000;
        static void Main(string[] args)
        {
            Stopwatch stringTotalMiliSeconds = StringTest();
            Stopwatch stringBuilderTotalMiliSeconds = StringBuilderTest();
            Console.WriteLine("--------------------Stopwatch--------------------");
            Console.WriteLine($"String: {stringTotalMiliSeconds.Elapsed} ms");
            Console.WriteLine($"StringBuilder: {stringBuilderTotalMiliSeconds.Elapsed} ms");
            Console.ReadLine();
        }

        private static Stopwatch StringTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string text = "";
            for (int i = 0; i < count; i++)
            {
                text += i.ToString();
            }
            stopwatch.Stop();
            return stopwatch;
        }

        private static Stopwatch StringBuilderTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(i.ToString());
            }
            stopwatch.Stop();
            return stopwatch;
        }
    }
}
