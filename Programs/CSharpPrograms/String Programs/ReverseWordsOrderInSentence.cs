using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.String_Programs
{
    public class ReverseWordsOrderInSentence : IProgram
    {
        public string Name => "Reverse words order in sentence";

        public void Run()
        {
            Console.WriteLine("Enter string to reverse words order");
            string str = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            StringBuilder word = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] != ' ')
                {
                    // Build word in reverse order
                    word.Insert(0, str[i]);
                }
                else
                {
                    // Append complete word
                    result.Append(word);
                    result.Append(' ');
                    word.Clear();
                }
            }

            // Append first word
            result.Append(word);

            Console.WriteLine(result.ToString());
        }
    }
}
