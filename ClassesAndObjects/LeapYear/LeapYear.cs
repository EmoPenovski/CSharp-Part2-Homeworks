/*      Problem 1. Leap year

    Write a program that reads a year from the console and checks whether it is a leap one.
    Use System.DateTime.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter year to check if it is leap: ");
                int checkedYear = int.Parse(Console.ReadLine());
                Console.WriteLine("This year is leap? => {0}", DateTime.IsLeapYear(checkedYear));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
