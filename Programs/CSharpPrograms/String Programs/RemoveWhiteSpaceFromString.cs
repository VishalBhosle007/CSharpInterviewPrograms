using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.String_Programs
{
    public class RemoveWhiteSpaceFromString : IProgram
    {
        public string Name => "Remove all white spaces from a string.";

        public void Run()
        {
            Console.WriteLine("Enter a string to remove all white spaces:");
            string input = Console.ReadLine() ?? "";

            StringBuilder resultBuilder = new StringBuilder();
            foreach (char c in input)
            {
                if (!char.IsWhiteSpace(c))
                {
                    resultBuilder.Append(c);
                }
            }
            Console.WriteLine(resultBuilder.ToString());
        }
    }
}
