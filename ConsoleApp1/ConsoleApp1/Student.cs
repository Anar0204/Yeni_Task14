using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public Student(string name,string groupNo,int age)
        {
            Age = age;
            Name = name;
            GroupNo = groupNo;
        }
        string _name;
        private string _groupNo;
        public string Name {
            get
            { 
                return _name;
            } set 
            {
                if (IsValidFullName(value))
                {
                    _name = value;
                }
            } 
        }
        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if(Regex.IsMatch(value, @"^[A-Z]{1}[0-9]{3}$"))
                {
                    _groupNo = value;
                }
            }
        }
        public int Age;


        public bool IsValidFullName(string fullname)
        {
            if (string.IsNullOrWhiteSpace(fullname))
                return false;

            var parts = fullname.Trim().Split(' ');
            if (parts.Length != 2)
            {
                return false;
            }

            foreach (string part in parts)
            {
                if (string.IsNullOrWhiteSpace(part))
                    return false;

                foreach (char c in part)
                {
                    if (!char.IsLetter(c))
                        return false;
                }
            }

            return true;

        }

        public static bool CheckFullname(string fullname)
        {
            if (string.IsNullOrWhiteSpace(fullname))
                return false;

            var parts = fullname.Trim().Split(' ');

            if (parts.Length != 2)
                return false;

            foreach (string part in parts)
            {
                if (string.IsNullOrWhiteSpace(part))
                    return false;

                foreach (char c in part)
                {
                    if (!char.IsLetter(c))
                        return false;
                }
            }

            return true;
        }

        
        public static bool CheckGroupNo(string groupNo)
        {
            return Regex.IsMatch(groupNo, @"^[A-Z]{1}[0-9]{3}$");
        }

        public virtual void DoHomework()
        {
            
        }

    }
}
