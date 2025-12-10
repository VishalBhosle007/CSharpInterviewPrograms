using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms
{
    public class Fibonacci_Recursion : IProgram
    {
        // Function to calculate Fibonacci number using recursion
        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public string Name => "Fibonacci with recursion";

        public void Run()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}
