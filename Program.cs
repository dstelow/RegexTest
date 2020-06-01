using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            const string pattern = @"(S|B|A)-\d{3}-(19|20)\d{2}";
            Console.WriteLine($"Regex pattern: {pattern}");
            Console.WriteLine();

            string[] inputs = {
                "S-123-2020", 
                "B-543-1999",
                "A-642-2021",
                "G-123-2020",
                "S-123-2120",
                "s-123-2020"
            };

            foreach (string input in inputs)
            {
                var match = Regex.Match(input, pattern);
                Console.WriteLine($"input '{input}' is valid:  {match.Success}");
            }
            Console.ReadKey();
        }
    }
}