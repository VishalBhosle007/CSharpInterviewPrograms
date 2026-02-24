using Programs.CSharpPrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewPrograms.CSharpPrograms.Array_Programs
{
    public class FindDuplicatesElementsFromArray : IProgram
    {
        public string Name => "Find all duplicate elements from array";

        public void Run()
        {
            int[] arr = { 22, 23, 59, 39, 33, 22, 30, 49, 23, 33 };
            HashSet<int> visited = new HashSet<int>();
            List<int> duplicates = new List<int>();

            foreach (int i in arr)
            {
                if (!visited.Add(i))
                {
                    duplicates.Add(i);
                }
            }

            if (duplicates.Any())
            {
                Console.WriteLine(string.Join(", ", duplicates));
            }

        }
    }
}
