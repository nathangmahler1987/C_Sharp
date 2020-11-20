using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe01
{
    class Student
    {
        //class attributes
        public string name;
        public string major;
        public double GPA;

        //constructor method
        public Student(string aName, string aMajor, double aGPA)
        {
            name = aName;
            major = aMajor;
            GPA = aGPA;
        }
        // object method
        public bool HasHonors()
        {
            if (GPA >= 3.5)
            {
                return true;
            }
            return false;
        }
        public bool Department()
        {
            if (major == "Business")
            {
                return true;
            }
            return false;
        }
    }
}
