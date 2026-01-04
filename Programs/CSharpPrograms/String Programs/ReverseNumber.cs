using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.String_Programs
{
    public class ReverseNumber : IProgram
    {
        public string Name => "Reverse a number";

        public void Run()
        {
            Console.WriteLine("Enter number to reverse");
            int input = int.Parse(Console.ReadLine());

            int reversedNumber = 0;
            while (input > 0)
            {
                int digit = input % 10;
                reversedNumber = (reversedNumber * 10) + digit;
                input /= 10;
            }

            Console.WriteLine($"Reversed Number is {reversedNumber}");
        }
    }
}
