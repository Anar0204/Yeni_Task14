using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DesignStudent : Student
    {
        public DesignStudent(string name, string groupNo, int age) : base(name, groupNo, age)
        {
        }

        public override void DoHomework()
        {
            Console.WriteLine("Design homework");
        }
    }
}
