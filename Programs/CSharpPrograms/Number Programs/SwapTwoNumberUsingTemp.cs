using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.Number_Programs
{
    public class SwapTwoNumberUsingTemp : IProgram
    {
        public string Name => "Swap two number using third/temp variable";

        public void Run()
        {
            Console.Write("Enter value for A :");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter value for B :");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before Swapping: a = {a}, b = {b}");

            // Swapping using a temporary variable
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After Swapping: a = {a}, b = {b}");
        }
    }
}
