using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem_1
{
    public class ZooUtility
    {
        public static void DescribeAnimal(string name)
        {
            Console.WriteLine($"Animal Name: {name}");
        }

        public static void DescribeAnimal(string name, string species)
        {
            //DescribeAnimal(name);
            Console.WriteLine($"Animal Name: {name}, Species: {species}");
        }

        public static void DescribeAnimal(string name, string species, int age)
        {
            //DescribeAnimal(name, species);
            Console.WriteLine($"Animal Name: {name}, Species: {species}, Age: {age} years old");
        }
    }
}
