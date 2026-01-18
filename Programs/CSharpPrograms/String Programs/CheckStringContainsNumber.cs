using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.String_Programs
{
    public class CheckStringContainsNumber : IProgram
    {
        public string Name => "Check string contains only digits";

        public static bool CheckDigitContain(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public void Run()
        {
            Console.WriteLine("Enter string to check strig contains only digits");
            string str = Console.ReadLine();

            var Result = CheckDigitContain(str);

            Console.WriteLine(Result ? "string contains only digits" : "Not contains only digits");

        }
    }
}
