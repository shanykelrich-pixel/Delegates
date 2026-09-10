using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class Student
    {
        public string Name { get; set; }
        public string StudentClass { get; set; }

        public Student(string name, string studentClass)
        {
            Name = name;
            StudentClass = studentClass;
        }
    }
}
