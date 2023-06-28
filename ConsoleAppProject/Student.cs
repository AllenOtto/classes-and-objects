using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    internal class Student
    {
        public string name;
        public int grade;
        public double gpa;

        public Student(string aName, int aGrade, double aGpa)
        {
            name = aName;
            grade = aGrade;
            gpa = aGpa;
        }

        public bool HasHonors()
        {
            if(gpa > 2.5)
            {
                return true;
            }
            return false;
        }
    }
}
