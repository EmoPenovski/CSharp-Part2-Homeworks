/*      Problem 10. Unicode characters

    Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.
    Example:
    
    input	output
    Hi!	\u0048\u0069\u0021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCodeChars
{
    class UniChars
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            StringBuilder convert = new StringBuilder();

            foreach (var ch in input)
            {
                convert.AppendFormat("\\u{0:X4}", (int)ch);
            }

            Console.WriteLine(convert.ToString());
        }
    }
}
