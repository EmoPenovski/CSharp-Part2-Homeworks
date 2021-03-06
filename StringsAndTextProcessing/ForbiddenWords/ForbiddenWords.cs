﻿/*      Problem 9. Forbidden words

    We are given a string containing a list of forbidden words and a text containing some of these words.
    Write a program that replaces the forbidden words with asterisks.
    Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
    Forbidden words: PHP, CLR, Microsoft
    The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                                         
namespace ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today." +
            " It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            string[] forbiddenWords = { "Microsoft", "PHP", "CLR" };

            string[] splittedText = text.Split(new char[] { '.', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                for (int j = 0; j < splittedText.Length; j++)
                {
                    if (splittedText[j] == forbiddenWords[i])
                    {
                        text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
                    }
                }
            }

            Console.WriteLine(text);
        }
    }
}
