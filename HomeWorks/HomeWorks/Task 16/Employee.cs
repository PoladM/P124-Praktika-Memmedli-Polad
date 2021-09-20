using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Employee
    {
        public int No;
        public string FullName;
        public double Salary;
        public string Position;
        static int count = 0;
        public Employee(string fullname,double salary,string position)
        {
            count++;
            No = count /*+ ". " + FullName*/;
            FullName = fullname;
            Salary = salary;
            Position = position;
        }
    }
}
