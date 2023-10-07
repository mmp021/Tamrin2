using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Cat("Cat", new List<string> { "Persian", "Siamese" }, "Meow", "Fish"),
                new Dog("Dog", new List<string> { "German Shepherd", "Husky" }, "Woof", "Meat"),
                new Bird("Bird", new List<string> { "Sparrow", "Eagle" }, "Chirp", "Seeds"),
                // Add other types of animals here
            };

            try
            {
                Console.WriteLine("Please select an animal:");
                for (int i = 0; i < animals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {animals[i].Name}");
                }

                int animalChoice = int.Parse(Console.ReadLine()) - 1;
                if (animalChoice >= 0 && animalChoice < animals.Count)
                {
                    Animal selectedAnimal = animals[animalChoice];
                    Console.WriteLine($"You've chosen {selectedAnimal.Name}.");
                    Console.WriteLine("Please select a breed of this animal:");

                    for (int i = 0; i < selectedAnimal.Breeds.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {selectedAnimal.Breeds[i]}");
                    }

                    int breedChoice = int.Parse(Console.ReadLine()) - 1;
                    if (breedChoice >= 0 && breedChoice < selectedAnimal.Breeds.Count)
                    {
                        string selectedBreed = selectedAnimal.Breeds[breedChoice];
                        Console.WriteLine($"You've chosen the {selectedBreed} breed.");
                        Console.WriteLine($"Attributes of {selectedAnimal.Name} {selectedBreed}:");

                        selectedAnimal.DisplayInfo();
                    }
                    else
                    {
                        Console.WriteLine("Invalid breed selection.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid animal selection.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

}
 
