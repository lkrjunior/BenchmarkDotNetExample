using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetExample
{
    [MemoryDiagnoser]
    public class PalindromeHandler
    {
        //[Params("osso", "arara", "lucianoaonaicul", "lucianoonaicul", "luciano")]
        [Params("arara")]
        public string value { get; set; }

        [Benchmark]
        public bool PalindromeV1()
        {
            var invertWord = "";

            for (int i = value.Length - 1; i >= 0; i--)
            {
                invertWord += value.Substring(i, 1);
            }

            var isTrue = value == invertWord;

            return (isTrue);

        }

        [Benchmark]
        public bool PalindromeV2()
        {
            var invertWord = "";

            for (int i = value.Length - 1; i >= 0; i--)
            {
                invertWord += value[i];
            }

            var isTrue = value == invertWord;

            return (isTrue);

        }

        [Benchmark]
        public bool PalindromeV3()
        {
            var mod = value.Length % 2;
            var half = value.Length / 2;

            var finalWord = "";

            for (int i = value.Length - 1; i >= (half + mod); i--)
            {
                finalWord += value[i];
            }

            var isTrue = value.Substring(0, half) == finalWord;

            return (isTrue);
        }

        [Benchmark]
        public bool PalindromeV4()
        {
            var mod = value.Length % 2;
            var half = value.Length / 2;

            var finalWord = "";

            for (int i = value.Length - 1; i >= (half + mod); i--)
            {
                finalWord += value.Substring(i, 1);
            }

            var isTrue = value.Substring(0, half) == finalWord;

            return (isTrue);
        }
    }
}
