/*      Problem 18. Extract e-mails

    Write a program for extracting all email addresses from given text.
    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractEMails
{
    class Emails
    {
        static void Main()
        {
            string text = "Contact Telerik at telerik@telerik.com or peshogoshov@gmail.com";

            foreach (var item in Regex.Matches(text, @"\w+@\w+\.\w+"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
