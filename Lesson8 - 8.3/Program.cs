using System;
using System.Collections.Generic;

namespace MiniExercise12_3_ClassifyWork
{
    public class Program
    {
        public static void Main()
        {
            var examples = new List<(string Work, string Classification)>
          {
              ("File.ReadAllTextAsync(...)", "I/O-bound"),
              ("HttpClient.GetStringAsync(...)", "I/O-bound"),
              ("summing 1 to 50 million in a loop", "CPU-bound"),
              ("a database query", "I/O-bound")
          };

            Console.WriteLine("Classification results:");

            foreach (var example in examples)
            {
                Console.WriteLine($"{example.Work} -> {example.Classification}");
            }
        }
    }
}