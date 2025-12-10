using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms
{
    public class Fibonacci : IProgram
    {
        public string Name => "Fibonacci series without recursion";

        public void Run()
        {
            // Fibonacci series without recursion

            int n = 10;
            int a = 0, b = 1, c;
            Console.WriteLine(a);
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
