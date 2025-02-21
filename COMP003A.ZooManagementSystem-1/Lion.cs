using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace COMP003A.ZooManagementSystem_1
{
    internal class Lion : Animal
    {
        public Lion(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The lion roars! ({Name}, {Species})");
        }
    }
}
