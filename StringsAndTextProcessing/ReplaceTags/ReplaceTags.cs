/*Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
Example:

input	                                                                output
<p>Please visit <a href="http://academy.telerik.                        <p>Please visit [URL=http://academy.telerik. com]our
com">our site</a> to choose a training course. Also                     site[/URL] to choose a training course. Also visit
visit <a href="www.devbg.org">our forum</a> to discuss                  [URL=www.devbg.org]our forum[/URL] to discuss the 
the courses.</p>	                                                    courses.</p>
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string html = Console.ReadLine();
            string replaced = html.Replace(@"<a href=""", "[URL=");
            replaced = replaced.Replace(@""">", "]");
            replaced = replaced.Replace("</a>", "/URL]");
            Console.WriteLine(new string('-', 80));
            Console.WriteLine(replaced);

        }
    }
}
