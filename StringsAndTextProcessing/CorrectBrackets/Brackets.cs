/*      Problem 3. Correct brackets

    Write a program to check if in a given expression the brackets are put correctly.
    Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class Brackets
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            bool correct = CheckBrackets(input);

            if (correct)
            {
                Console.WriteLine("Brackets are correct");
            }
            else
            {
                Console.WriteLine("Incorrect brackets");
            }
        }

        static bool CheckBrackets(string input)
        {
            int counter = 0;

            if (input[0] == ')')
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    counter++;
                }
                else if (input[i] == ')')
                {
                    counter--;
                }
            }

            if (counter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
