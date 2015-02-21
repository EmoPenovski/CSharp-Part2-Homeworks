/*      Problem 1. Say Hello

    Write a method that asks the user for his name and prints “Hello, <name>”
    Write a program to test this method.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class Greetings
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you name: ");
            string name = Console.ReadLine();
            Console.WriteLine(SayHello(name));
        }
        static string SayHello(string input)
        {
            return string.Format("Hello, {0}!", input);
        }
        
    }
}
