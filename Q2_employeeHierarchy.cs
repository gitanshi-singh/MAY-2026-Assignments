using System;
using System.Collections.Generic;
using System.Text;

namespace MAY_260526
{
    class Employee
    {
        public string Name;

        public List<Employee> Subordinates =
            new List<Employee>();

        public Employee(string name)
        {
            Name = name;
        }

        public void AddSubordinate(Employee emp)
        {
            Subordinates.Add(emp);
        }
        public void Display(int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write("   ");
            }

            Console.WriteLine(Name);

            foreach (Employee emp in Subordinates)
            {
                emp.Display(level + 1);
            }
        }
    }
    internal class Q2_employeeHierarchy
    {
//create tree structure (ceo, manager, subordinates)
    public static void Run()
        {
            Employee ceo = new Employee("CEO");

            Employee manager1 = new Employee("Manager A");
            Employee manager2 = new Employee("Manager B");

            Employee emp1 = new Employee("Employee 1");
            Employee emp2 = new Employee("Employee 2");
            Employee emp3 = new Employee("Employee 3");

            manager1.AddSubordinate(emp1);
            manager1.AddSubordinate(emp2);

            manager2.AddSubordinate(emp3);

            ceo.AddSubordinate(manager1);
            ceo.AddSubordinate(manager2);

            Console.WriteLine("Company Hierarchy:\n");

            ceo.Display(0);

        }
    }
}
