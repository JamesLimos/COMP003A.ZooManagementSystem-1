using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem_1
{
    abstract class Animal
    {
        private string _name;
        private string _species;
        private int _age;

        public string Name { get; set; }
        public string Species { get; set; }

        public int Age { get; set; }

        public abstract void MakeSound();
        
        
    }
}
