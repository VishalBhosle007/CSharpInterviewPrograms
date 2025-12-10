using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.C__Programs
{
    public class StringPalindrome
    {
        public static void CheckPalindrome()
        {
            string str = "vishal";

            int start = 0;
            int end = str.Length - 1;

            bool isPalindrome = true;

            while (start < end)
            {
                if (str[start] != str[end])
                {
                    isPalindrome = false;
                    break;
                }
                start++;
                end--;
            }

            Console.WriteLine(isPalindrome ? $"{str} is a palindrome." : $"{str} is not a palindrome.");
        }
    }
}
