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
                Console.WriteLine("\n Zoo Management System Menu ");
                Console.WriteLine("1. Add a Lion.");
                Console.WriteLine("2. Add a Parrot.");
                Console.WriteLine("3. Display All Animals.");
                Console.WriteLine("4. Describe an Animal using ZooUtility");
                Console.WriteLine("5. Exit");
                int choice = int .Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the name of the Lion: ");
                        string lionName = Console.ReadLine();
                        Console.Write("Enter the Species of the lion: ");
                        string lionSpecies = Console.ReadLine();
                        animals.Add(new Lion(lionName, lionSpecies);
                        Console.WriteLine("Lion added successfully!");
                        break;
                    case 2:
                        Console.Write("Enter the name of the Parrot: ");

                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
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
