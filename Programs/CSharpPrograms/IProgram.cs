using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.CSharpPrograms
{
    public interface IProgram
    {
        string Name { get; }
        void Run();
    }
}
