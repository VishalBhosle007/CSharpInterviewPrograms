using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.Number_Programs
{
    public class MinAndMaxNumberFromArray : IProgram
    {
        public string Name => "Find minimum and maximum number form array";

        int[] arr = { 22, 34, 59, 38, 39, 94, 27, 4, 28, 19 };

        public void Run()
        {
            int min = arr[0];
            int max = arr[0];

            foreach (int num in arr)
            {
                //Minimum
                if (min > num)
                {
                    min = num;
                }

                //Maximum
                if (max < num)
                {
                    max = num;
                }
            }

            Console.WriteLine($"Minimum number is : {min}\nMaximum number is : {max}");
        }
    }
}
