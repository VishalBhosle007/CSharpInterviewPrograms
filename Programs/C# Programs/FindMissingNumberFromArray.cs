using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class FindMissingNumberFromArray
    {
        public static void MissingNumberExercise()
        {
            int[] arr = { 17,19,20,21,22,23 };

            int min = arr[0];
            int max = arr[0];

            //Finding Minimum and Maximum number form array;
            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            Console.WriteLine($"Min {min}");
            Console.WriteLine($"Max {max}");

            //Expected sum through formula
            int ExpectedSum = (max - min + 1) * (min + max) / 2;

            //Actual Sum calculated
            int ActualSum = 0;
            foreach (int num in arr)
            {
                ActualSum += num;
            }

            Console.WriteLine($"Missing number from array is {ExpectedSum - ActualSum}");
        }
    }
}
