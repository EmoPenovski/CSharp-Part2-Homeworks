/*      Problem 4. Sub-string in text

    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
    Example:
    The target sub-string is in
    The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
    The result is: 9
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringInAText
{
    class SubString
    {
        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine."
                   + " We don't have anything else. Inside the submarine is very tight."
                   + " So we are drinking all the day. We will move out of it in 5 days.";

            string search = "in";

            int count = 0;
            int index = text.ToLower().IndexOf(search, 0);

            while (index >= 0)
            {
                count++;
                index++;
                index = text.ToLower().IndexOf(search, index);
            }
            Console.WriteLine(count);
        }
    }
}
