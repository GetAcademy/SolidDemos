using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDemos
{
    class Student : Person
    {
        public int StudentNo { get; }

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }
    }
}
