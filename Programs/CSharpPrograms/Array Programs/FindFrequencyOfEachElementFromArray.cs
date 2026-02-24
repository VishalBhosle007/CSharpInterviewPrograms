using Programs.CSharpPrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewPrograms.CSharpPrograms.Array_Programs
{
    public class FindFrequencyOfEachElementFromArray : IProgram
    {
        public string Name => "Find frequency of each element in an array";

        public void Run()
        {
            int[] arr = { 29, 39, 39, 488, 38, 92, 56, 69, 38, 488 };
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict[i] = 1;
                }
            }

            foreach( var ele in dict)
            {
                Console.WriteLine($"{ele.Key} repeats {ele.Value} times");
            }
        }
    }
}
