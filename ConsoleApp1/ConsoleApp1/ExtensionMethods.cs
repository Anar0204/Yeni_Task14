using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class ExtensionMethods
    {
        
        public static bool IsOdd( int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven( int number)
        {
            return number % 2 == 0;
        }

        public static bool IsContainsdigit(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                    return true;
            }
            return false;
        }

        public static string Capitalize(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
                

            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }

        public static int[] GetValueIndexes(string input, char target)
        {
            if (string.IsNullOrWhiteSpace(input))
                return new int[0];

           
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == target)
                    count++;
            }

         
            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == target)
                {
                    result[index] = i;
                    index++;
                }
            }

            return result;
        }

        public static string GetFirstSentence(string input)
        {

            int index = input.IndexOf('.');
            if (index == -1)
            {
                return input.Trim();
            }
             


            return input.Substring(0,index + 1).Trim();
        }

        public static string GetSecondWord(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            
            string[] words = input.Split(' ');
            if(words.Length >= 2)
            {
                return words[1];
            }
            else
            {
                return " ";
            }
        }
    }
}
