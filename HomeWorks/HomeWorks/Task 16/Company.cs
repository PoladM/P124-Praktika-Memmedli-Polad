using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Company
    {
        public string Name;
        public int Limit;
        public Employee[] Employees;

        public Company(string name, int limit)
        {
            Employees = new Employee[0];
            Name = name;
            Limit = limit;
        }

        public void AddEmployee(Employee employee)
        {
            if (Limit > Employees.Length)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = employee;
            }
            else
            {
                Console.WriteLine($"Limit {Limit} iscidir.");
            }
        }

        public void GetEmployees()
        {
            foreach (var item in Employees)
            {
                Console.WriteLine($"{item.No} {item.FullName} {item.Position} {item.Salary}");
            }
        }

        public Employee[] SearchEmployees(string search)
        {
            Employee[] arr = new Employee[0];
            int i;
            for (i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].FullName == search)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = Employees[i];
                    break;
                }
                
            }
            if (i == Employees.Length)
            {
                Console.WriteLine("Isci tapilmadi.");
            }
            return arr;
        }

        public void RemoveEmployee(int no)
        {
            int i;
            int pos;
            foreach (var item in Employees)
            {
                if (item.No == no)
                {
                    pos = Array.IndexOf(Employees, item);
                    if (Employees.Length>1)
                    {
                        for (i = pos; i < Employees.Length - 1; i++)
                        {
                            Employees[i] = Employees[i + 1];
                        }
                        Array.Resize(ref Employees, Employees.Length - 1);
                    }
                    else
                    {
                        Array.Resize(ref Employees, 0); 
                    }
                }
            }
        }
    }
}
