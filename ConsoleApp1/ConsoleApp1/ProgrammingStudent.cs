using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProgrammingStudent:Student
    {
        public ProgrammingStudent(string name, string groupNo, int age) : base(name, groupNo, age)
        {
        }

        public override void DoHomework()
        {
            Console.WriteLine("PG DOING HOMEWORK");
        }
    }
}
