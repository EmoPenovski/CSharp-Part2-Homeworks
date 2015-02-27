/*      Problem 16. Date difference

    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
    Example:
    
    Enter the first date: 27.02.2006
    Enter the second date: 3.03.2006
    Distance: 4 days
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateDifference
{
    class Differences
    {
        static void Main(string[] args)
        {
            // check for your format and region then enter the date
            Console.Write("Enter first date in the format month/day/year: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Enter second date in the format month/day/year: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            TimeSpan daysBetween = firstDate - secondDate;

            Console.WriteLine("Days between: " + Math.Abs(daysBetween.Days));
        }
    }
}
