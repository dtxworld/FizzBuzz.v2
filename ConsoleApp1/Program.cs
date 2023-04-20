using SuperFizzBuzz;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        /// <summary>
        /// Solve the good ol' classic FizzBuzz problem
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var rangeList = Tuple.Create(1, 100);
            var tokenList = new List<(int, string)>  {  (3, "Fizz"), (5, "Buzz") };

            FizzBuzz fb = new FizzBuzz(rangeList, tokenList);
            Console.WriteLine(fb.Output());
            Console.WriteLine("Console App 1 Complete! Press any key to exit...");
            Console.ReadKey();
        }
    }
}