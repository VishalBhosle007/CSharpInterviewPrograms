using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms.Array_Programs
{
    public class RemoveDuplicateFromArray : IProgram
    {
        public string Name => "Remove duplicates from an integer array";

        public void Run()
        {
            int[] arr = { 1, 2, 3, 1, 2, 4, 7, 8, 9 };

            HashSet<int> seen = new HashSet<int>();
            List<int> Result = new List<int>();

            foreach (int i in arr)
            {
                if (seen.Add(i))
                {
                    Result.Add(i);
                }
            }

            Console.WriteLine(string.Join(',', Result));
        }
    }
}
