using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Student_2
    {
        static int Count = 120;
        public string FullName;
        public string GroupNo;
        public byte Age;

        public Student_2(string fullname, byte age)
        {
            Count++;
            GroupNo = "P" + Count;
            FullName = fullname;
            Age = age;
        }


       public static bool CheckGroupNo(string groupno,Student_2 student)
        {
            if (student.GroupNo == groupno)
            {
                return  true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckFullName(string fullname, Student_2 student)
        {
            if (student.FullName == fullname)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
