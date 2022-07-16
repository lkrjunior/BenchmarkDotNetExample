using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;

namespace BenchmarkDotNetExample
{
    [MemoryDiagnoser]
    [RankColumn(NumeralSystem.Arabic)]
    public class PalindromeHandler
    {
        //[Params("osso", "arara", "lucianoaonaicul", "lucianoonaicul", "luciano")]
        [Params("arara")]
        public string Value { get; set; }

        [Benchmark]
        //[Benchmark(Baseline = true)]
        public bool PalindromeV1()
        {
            var invertWord = "";

            for (int i = Value.Length - 1; i >= 0; i--)
            {
                invertWord += Value.Substring(i, 1);
            }

            var isTrue = Value == invertWord;

            return isTrue;

        }

        [Benchmark]
        public bool PalindromeV2()
        {
            var invertWord = "";

            for (int i = Value.Length - 1; i >= 0; i--)
            {
                invertWord += Value[i];
            }

            var isTrue = Value == invertWord;

            return isTrue;

        }

        [Benchmark]
        public bool PalindromeV3()
        {
            var mod = Value.Length % 2;
            var half = Value.Length / 2;

            var finalWord = "";

            for (int i = Value.Length - 1; i >= (half + mod); i--)
            {
                finalWord += Value[i];
            }

            var isTrue = Value.Substring(0, half) == finalWord;

            return isTrue;
        }

        [Benchmark]
        public bool PalindromeV4()
        {
            var mod = Value.Length % 2;
            var half = Value.Length / 2;

            var finalWord = "";

            for (int i = Value.Length - 1; i >= (half + mod); i--)
            {
                finalWord += Value.Substring(i, 1);
            }

            var isTrue = Value.Substring(0, half) == finalWord;

            return isTrue;
        }
    }
}
