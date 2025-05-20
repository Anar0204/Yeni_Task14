using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class StringExtentions
    {
        public static int MatchCount(string originalText, string checkText)
        {
            if (string.IsNullOrEmpty(originalText) || string.IsNullOrEmpty(checkText))
                return 0;

            int count = 0;
            int index = 0;

            while ((index = originalText.IndexOf(checkText, index)) != -1)
            {
                count++;
                index += checkText.Length;
            }

            return count;
        }

        public static bool IsPalindrome(int number)
        {
            string str = number.ToString();
            char[] reversed = str.ToCharArray();
            Array.Reverse(reversed);
            return str == new string(reversed);
        }
    }
}
