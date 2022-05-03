using System;
using System.Collections.Generic;
using System.Text;

namespace MaxCharCount
{
    class CharCount
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            CalcMaxCharCount(str);
        }

        private static void CalcMaxCharCount(string inputStr)
        {
            inputStr = inputStr.ToLower();
            char[] charArray = inputStr.ToCharArray();

            int[] letterCounts = new int[256];
            int maxCount = 0;
            char maxChar = ' ';

            foreach (var r in charArray)
            {
                letterCounts[r] = letterCounts[r] + 1;
                if (maxCount < letterCounts[r])
                {
                    maxCount = letterCounts[r];
                    maxChar = r;
                }
            }
            Console.WriteLine("Character " + maxChar + " has maximum occurences: " + maxCount);
        }

    }
}
