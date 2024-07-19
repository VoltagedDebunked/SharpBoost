using System;
using System.Threading.Tasks;

namespace SharpBoost
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: SharpBoost <solution-path>");
                return;
            }

            var solutionPath = args[0];
            await CodeAnalyzer.AnalyzeCodeAsync(solutionPath);
        }
    }
}