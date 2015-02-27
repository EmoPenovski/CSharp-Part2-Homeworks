/*Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example:

input	                |    output
------------------------|-----------
aaaaabbbbbcdddeeeedssaa |    abcdedsa
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class SeriesLetter
    {
        static void Main(string[] args)
        {
            string text = "aaaaabbbbbcdddeeeedssaab";

            StringBuilder sb = new StringBuilder();

            char previous = text[0];

            sb.Append(previous);

            for (int i = 1; i < text.Length; i++)
            {
                if (previous != text[i])
                {
                    sb.Append(text[i]);
                }

                previous = text[i];
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
