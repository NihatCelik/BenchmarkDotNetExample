using BenchmarkDotNet.Running;
using System;

namespace BenchmarkDotNetExample.BenchmarkCalculating
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<StringVsStringBuilder>();
        }
    }
}
