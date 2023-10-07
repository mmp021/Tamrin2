using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin2
{
    // Base class for all animals
    class Animal
    {
        public string Name { get; set; }
        public List<string> Breeds { get; set; }
        public string Sound { get; set; }
        public string Food { get; set; }

        public Animal(string name, List<string> breeds, string sound, string food)
        {
            Name = name;
            Breeds = breeds;
            Sound = sound;
            Food = food;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Type: {Name}");
            Console.WriteLine("Breeds:");
            foreach (var breed in Breeds)
            {
                Console.WriteLine($"- {breed}");
            }
            Console.WriteLine($"Sound: {Sound}");
            Console.WriteLine($"Food: {Food}");
        }
    }
}
