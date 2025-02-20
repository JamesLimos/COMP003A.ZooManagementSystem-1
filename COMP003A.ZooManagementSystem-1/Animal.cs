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

        public string Name { get; set; }
        public string Species { get; set; }

        public virtual void MakeSound()
        { 
        }
    }
}
