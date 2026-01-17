using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.Array_Programs
{
    public class ReverseArrayInPlace : IProgram
    {
        public string Name => "Reverse array in-place (without using another array)";

        public void Run()
        {
            int[] arr = { 12, 23, 44, 59, 30, 37, 60};

            Console.WriteLine("Before Reverse : ");
            Console.WriteLine(string.Join(',', arr));
            
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                //Swaping elements
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }

            Console.WriteLine("After Reverse : ");
            Console.WriteLine(string.Join(',', arr));

        }
    }
}
