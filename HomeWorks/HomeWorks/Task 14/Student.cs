using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Student
    {
        public string Name { get { return _name; } set { _name = value; } }
        public string SurName { get {return _surname; } set {_surname = value; } }

        private string _name;
        private string _surname;


        public Student(string name, string surname)
        {
           Name = name;
            SurName = surname;
        }

    }
}
