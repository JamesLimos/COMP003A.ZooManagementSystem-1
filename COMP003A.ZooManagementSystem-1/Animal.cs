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

        public string Name 
        { 
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(" Name cannot be empty. Please provide a valid name.");
                }
                _name = value;
            }
        }
        public string Species 
        {
            get { return _species; } 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Species name cannot be empty.Please provide a valid name.");
                }
                _species = value;
            }
        }
        public int Age { get; set; }
        public abstract void MakeSound();
      
    }
}
