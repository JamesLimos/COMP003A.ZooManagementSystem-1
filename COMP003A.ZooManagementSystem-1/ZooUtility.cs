using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem_1
{
    class ZooUtility
    {
        public string DescribeAnimal(string name)
        {
            return DescribeAnimal(name);
        }

        public string DescribeAnimal(string name, string species)
        {
            return DescribeAnimal(name) + DescribeAnimal(species); 
        }

        public string DescribeAnimal(string name, string species, int age)
        {
            return 5 + DescribeAnimal(name) + DescribeAnimal(species);
        }
    }
}
