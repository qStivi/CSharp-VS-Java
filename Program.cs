using System;
using System.Diagnostics;

namespace CSharp_VS_Java
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            for (var i = 0; i < 10000; i++) Console.WriteLine("HelloWorld!");
            stopwatch.Stop();

            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
    }
}
