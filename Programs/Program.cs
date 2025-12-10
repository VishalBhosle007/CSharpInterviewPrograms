using CSharpPrograms;
using Programs;
using Programs.CSharpPrograms;
using System.Threading.Tasks;

class Program
{
    public static async Task Main(string[] args)
    {
        // Find all classes that implement IProgram (in your project)
        List<IProgram> programs = GetAllPrograms();

        while (true)
        {

            Console.Clear();
            Console.WriteLine("=== C# Programs ===\n");

            // Show numbered list of programs
            for (int i = 0; i < programs.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {programs[i].Name}");
            }
            Console.WriteLine("0. Exit");

            Console.Write("\nEnter your choice: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input. Press any key to try again...");
                Console.ReadKey();
                continue;
            }

            if (choice == 0)
                return; // Exit program

            if (choice < 1 || choice > programs.Count)
            {
                Console.WriteLine("Invalid choice. Press any key to try again...");
                Console.ReadKey();
                continue;
            }

            Console.Clear();
            IProgram selectedProgram = programs[choice - 1];
            Console.WriteLine($"Running: {selectedProgram.Name}\n");
            selectedProgram.Run();

            Console.WriteLine("\n\nPress any key to go back to menu...");
            Console.ReadKey();
        }

        static List<IProgram> GetAllPrograms()
        {
            // 1. Look at the assembly (EXE/DLL) where Program is located.
            //    This means: "Search inside the currently running project."
            var assembly = typeof(Program).Assembly;

            // 2. Get every type (class, interface, struct, etc.) inside this assembly.
            var allTypes = assembly.GetTypes();

            // 3. Filter the types so we only keep:
            //    - classes that implement IProgram
            //    - classes that are not abstract (so we can create them)
            var programTypes = allTypes.Where(t =>
                typeof(IProgram).IsAssignableFrom(t) && // implements IProgram
                t.IsClass &&                             // is a class (not interface)
                !t.IsAbstract                            // can be created
            );

            // 4. Create an instance (object) of each program class.
            //    Activator.CreateInstance creates the object at runtime.
            var programInstances = programTypes
                .Select(t => (IProgram)Activator.CreateInstance(t)!);

            // 5. Sort the list by the program's Name property and convert to List.
            return programInstances
                .OrderBy(p => p.Name)
                .ToList();
        }

    }
}