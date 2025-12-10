using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms
{
    internal class PrintPrimeNumbersInRange : IProgram
    {
        public string Name => "Print prime numbers in range";

        // Function to print prime numbers in a given range
        public void Run()
        {
            Console.WriteLine("Enter the start of the range:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end of the range:");
            int end = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Prime numbers between {start} to {end} are :");

            for (int n = start; n <= end; n++)
            {
                if (n <= 1)
                {
                    continue;
                }
                bool isPrime = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
