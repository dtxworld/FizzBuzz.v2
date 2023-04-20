using SuperFizzBuzz;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        /// <summary>
        /// Demonstrate advanced usage of SuperFizzBuzz w/custom range and tokens
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var outputList = Tuple.Create(-12, 145);
            var tokenList = new List<(int, string)>
                              {
                                  (3, "Fizz"),
                                  (7, "Buzz"),
                                  (38, "Bazz")
                              };

            FizzBuzz fb = new FizzBuzz(outputList, tokenList);
            Console.WriteLine(fb.Output());
            Console.WriteLine("Console App 2 Complete! Press any key to exit...");
            Console.ReadKey();
        }
    }
}