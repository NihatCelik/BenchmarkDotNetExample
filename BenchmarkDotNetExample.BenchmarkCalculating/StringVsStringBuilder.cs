using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchmarkDotNetExample.BenchmarkCalculating
{
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net50, launchCount: 3, warmupCount: 5, targetCount: 3)]
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60, launchCount: 3, warmupCount: 5, targetCount: 3)]
    [MeanColumn, MedianColumn]
    [MemoryDiagnoser]
    public class StringVsStringBuilder
    {
        [Params(100, 1000, 10000)]
        public int Count { get; set; }

        [Benchmark]
        public void StringTest()
        {
            string text = "";
            for (int i = 0; i < Count; i++)
            {
                text += i.ToString();
            }
        }

        [Benchmark]
        public void StringBuilderTest()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                stringBuilder.Append(i.ToString());
            }
        }
    }
}
