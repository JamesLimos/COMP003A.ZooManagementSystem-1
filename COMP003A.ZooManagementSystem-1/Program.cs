/* 
Author: James Limos
Course: COMP-003A
Faculty: Jonathan Cruz
Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
*/

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
                    case 1:
                        Console.Write("Enter the name of the Lion: ");
                        string lionName = Console.ReadLine();
                        Console.Write("Enter the species of the lion: ");
                        string lionSpecies = Console.ReadLine();
                        animals.Add(new Lion(lionName, lionSpecies));
                        Console.WriteLine("\nLion added successfully!\n");
                        break;
                    case 2:
                        Console.Write("Enter the name of the Parrot: ");
                        string parrotName = Console.ReadLine();
                        Console.Write("Enter the species of the Parrot: ");
                        string parrotSpecies = Console.ReadLine();
                        animals.Add(new Parrot(parrotName, parrotSpecies));
                        Console.WriteLine("\nParrot added successfully!\n");
                        break;
                    case 3:  
                        Console.WriteLine("Displaying all animals:\n");
                        foreach (Animal animal in animals)
                        {
                            animal.MakeSound();
                        }
                        break;
                    case 4: 
                        bool isRunning = true;

                        while (isRunning)
                        {
                            Console.WriteLine("\nMenu");
                            Console.WriteLine("1. Describe Name.");
                            Console.WriteLine("2. Describe Name and Species.");
                            Console.WriteLine("3. Describe Name, Species, and Age.");
                            Console.WriteLine("4. Exit");
                            Console.WriteLine("Your Choice: ");
                            int utilityChoice = int.Parse(Console.ReadLine());
                            switch (utilityChoice)
                            {
                                case 1:
                                    Console.WriteLine("DescribeAnimal (name only):");
                                    ZooUtility.DescribeAnimal("Simba");
                                    break;
                                case 2:
                                    Console.WriteLine("DescribeAnimal (name and species):");
                                    ZooUtility.DescribeAnimal("Polly", "Psittaciformes");
                                    break;
                                case 3:
                                    Console.WriteLine("DescribeAnimal (name, species, and age):");
                                    ZooUtility.DescribeAnimal("Charlie", "Elephant", 12);
                                    break;
                                case 4:
                                    isRunning = false;
                                    break;
                                default:
                                    Console.WriteLine("Invalid input. Please enter a valid number.");
                                    break;

                            }
                        }
                        break;
                    case 5: 
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
