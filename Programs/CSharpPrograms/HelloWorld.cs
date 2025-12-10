using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms
{
    public class HelloWorld : IProgram
    {
        public string Name => "Hello world";

        public void Run()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
