using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms
{
    public class CheckPrimeNumber : IProgram
    {
        public string Name => "Check given number is Prime or not";

        public void Run()
        {
            Console.WriteLine("Enter a number to check if it is prime:");
            int n = int.Parse(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine($"{n} is not a prime number.");
                return;
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
                Console.WriteLine($"{n} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{n} is not a prime number.");
            }
        }
    }
}
