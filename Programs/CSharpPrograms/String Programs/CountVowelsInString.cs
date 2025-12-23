using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.String_Programs
{
    public class CountVowelsInString : IProgram
    {
        public string Name => "Count Vowels in string";

        public void Run()
        {
            Console.WriteLine("Enter string to count vowels in string");
            string str = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(str))
                return;

            Dictionary<char, int> dict = new Dictionary<char, int>()
            {
                {'a', 0 },{'e',0 },{'i',0 },{'o',0 },{'u',0 }
            };

            foreach (var c in str.Replace(" ", "").ToLower())
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
            }

            foreach (var c in dict)
            {
                Console.WriteLine($"{c.Key} = {c.Value}");
            }
        }
    }
}
