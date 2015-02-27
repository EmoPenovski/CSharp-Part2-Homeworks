/*      Problem 6. Sum integers

    You are given a sequence of positive integer values written into a string, separated by spaces.
    Write a function that reads these values from given string and calculates their sum.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a sequence of integer numbers, separated by a single space: ");
            string input = Console.ReadLine();
            int[] integers = input.Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(integers.Sum());
        }
    }
}
