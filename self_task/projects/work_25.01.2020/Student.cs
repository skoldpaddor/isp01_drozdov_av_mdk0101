using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        private string name;
        private string course;
        private string gender;

        public string Name
        {
            get { return name; }
        }

        public string Course
        {
            get { return course; }
        }

        public string Gender
        {
            get { return gender; }
        }

        public Student(string namestud, string coursestud, string genderstud)
        {
            name = namestud;
            course = coursestud;
            gender = genderstud;
        }

        public override string ToString()
        {
            return ($"{Name} {Course} {Gender}");
        }
    }
}