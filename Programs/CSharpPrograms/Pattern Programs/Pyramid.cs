using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.Pattern_Programs
{
    public class Pyramid : IProgram
    {
        public string Name => "Print Triangle";

        public void Run()
        {
            int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                // Spaces
                for (int space = rows - i; space > 0; space--)
                {
                    Console.Write(" ");
                }

                // Stars
                for (int star = 1; star <= (2 * i - 1); star++)
                {
                    Console.Write("*");
                }

                //New Line
                Console.WriteLine();
            }
        }
    }
}
