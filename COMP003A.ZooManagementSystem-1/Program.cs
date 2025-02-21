using System.ComponentModel;
using System.Xml.Serialization;

namespace COMP003A.ZooManagementSystem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                Console.WriteLine("Welcome to the Zoo Management Menu\n");
                Console.WriteLine("Please choose an option: ");
                Console.WriteLine("1. Add a Lion.");
                Console.WriteLine("2. Add a Parrot.");
                Console.WriteLine("3. Display All Animals.");
                Console.WriteLine("4. Describe an Animal using ZooUtility");
                Console.WriteLine("5. Exit\n");
                Console.Write("Your Choice: ");
                int choice = int .Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:// Add Lion information
                        Console.Write("Enter the name of the Lion: ");
                        string lionName = Console.ReadLine();
                        Console.Write("Enter the species of the lion: ");
                        string lionSpecies = Console.ReadLine();
                        animals.Add(new Lion(lionName, lionSpecies));
                        Console.WriteLine("\nLion added successfully!\n");
                        break;
                    case 2:// Add Parrot information
                        Console.Write("Enter the name of the Parrot: ");
                        string parrotName = Console.ReadLine();
                        Console.Write("Enter the species of the Parrot: ");
                        string parrotSpecies = Console.ReadLine();
                        animals.Add(new Parrot(parrotName, parrotSpecies));
                        Console.WriteLine("\nParrot added successfully!\n");
                        break;
                    case 3: // View animals 
                        Console.WriteLine("Displaying all animals:\n");
                        foreach (Animal animal in animals)
                        {
                            animal.MakeSound();
                        }
                        break;
                    case 4: // describe the animals
                        
                        break;
                    case 5: // exit
                        Console.WriteLine("\nGoodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        break;
                }
            }
        }
    }
}
