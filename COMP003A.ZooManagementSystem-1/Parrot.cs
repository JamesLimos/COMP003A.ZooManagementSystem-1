using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem_1
{
    class Parrot : Animal
    {
        public Parrot(string name, string species) 
        { 
            Name = name;
            Species = species;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The parrot squawks! ({Name}, {Species})");
        }
    }
}
