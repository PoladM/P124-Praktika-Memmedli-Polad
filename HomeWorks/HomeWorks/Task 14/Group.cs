using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Group
    {
        static double count = 120;
        public string No;
        public int Limit;
        public Student[] Students;

        public Group(int limit)
        {
            count++;
            No = "P" + count;
            Limit = limit;
            Students = new Student[0];
        }

        public void AddStudent()
        {
            Console.WriteLine("Ad:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyad:");
            string surname = Console.ReadLine();

            Student student = new Student(name, surname);
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public void GetStudents()
        {
            foreach (var item in Students)
            {
                Console.Write(item.Name);
                Console.Write(item.SurName);
                Console.Write(No);
                Console.WriteLine();
            }
        }

    }
}
