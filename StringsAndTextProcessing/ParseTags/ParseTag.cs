﻿/*      Problem 5. Parse tags

    You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
    The tags cannot be nested.
    Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
    The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class ParseTag
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>." +
           " We don't have <upcase>anything</upcase> else.";

            bool inText = true;
            bool inOpenTag = false;
            bool inBetweenTags = false;
            bool inClosingTags = false;

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (inText)
                {
                    if (currentSymbol == '<')
                    {
                        inText = false;
                        inOpenTag = true;
                    }
                    else
                    {
                        output.Append(currentSymbol);
                    }
                }
                else if (inOpenTag)
                {
                    if (currentSymbol == '>')
                    {
                        inBetweenTags = true;
                        inOpenTag = false;
                    }
                }
                else if (inBetweenTags)
                {
                    if (currentSymbol == '<')
                    {
                        inBetweenTags = false;
                        if (text[i + 1] == '/')
                        {
                            inClosingTags = true;
                        }
                        else
                        {
                            inOpenTag = true;
                        }
                    }
                    else
                    {
                        output.Append(currentSymbol.ToString().ToUpper());
                    }
                }
                else if (inClosingTags)
                {
                    if (currentSymbol == '>')
                    {
                        inText = true;
                        inClosingTags = false;
                    }
                }
            }

            Console.WriteLine(output.ToString());
        }
    }
}
