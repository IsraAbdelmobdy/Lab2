using System;
using System.Collections.Specialized;

namespace Lab2Q1
{
    internal class Program
    {
        [Flags]
        enum Role
        {
            Admin = 1,
            Accountant = 2,
            Stock = 4,
            Reception = 8
        }

        struct Employee
        {
            public string Name;
            public double Salary;
            public Role Role;

            public void Dispaly()
            {
                Console.WriteLine($"Name: {Name}, Salary: {Salary}, Role: {Role}");
            }

            public void AssignRole(Role role)
            {
                Role = Role | role;
            }

            public bool HasRole(Role role)
            {
                if ((Role & role) == role)
                    return true;
                else
                    return false;
            }

        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Isra";
            emp.Salary = 10000;
            emp.Role = Role.Reception;

            emp.Dispaly();
            emp.AssignRole(Role.Admin);

            if (emp.HasRole(Role.Admin))
                Console.WriteLine($"Employee {emp.Name} has this rule");
            
            emp.Dispaly();
        }
    }
}