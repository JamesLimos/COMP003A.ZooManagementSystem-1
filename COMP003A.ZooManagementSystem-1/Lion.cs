using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem_1
{
    class Lion : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("The lion roars!");
        }
    }
}
