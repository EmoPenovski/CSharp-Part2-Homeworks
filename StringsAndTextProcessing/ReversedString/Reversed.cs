/*      Problem 2. Reverse string

    Write a program that reads a string, reverses it and prints the result at the console.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedString
{
    class Reversed
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            char[] input = Console.ReadLine().ToCharArray();

            Array.Reverse(input);

            Console.WriteLine(input);
        }
    }
}
