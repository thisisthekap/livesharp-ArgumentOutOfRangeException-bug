using System;
using System.Linq;
using test.lib;

namespace test.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Types: {string.Join(", ", typeof(A).Assembly.GetTypes().Select(t => t.Name))}");
        }
    }
}