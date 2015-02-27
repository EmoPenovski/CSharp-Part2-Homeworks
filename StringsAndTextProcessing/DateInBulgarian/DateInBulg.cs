/*      Problem 17. Date in Bulgarian

    Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateInBulgarian
{
    class DateInBulg
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine(); //"19.01.2014 07:00:00"
            DateTime date = DateTime.ParseExact(time, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            date = date.AddHours(6.5);
            Console.WriteLine("{0} {1}", date.ToString("dddd"), date);
        }
    }
}
