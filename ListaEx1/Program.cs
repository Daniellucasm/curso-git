using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListaEx1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int qtd = int.Parse(Console.ReadLine());

            //create list
            List<Employee> list = new List<Employee>();

            //insert employees
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Employee #" + i);
                //get values
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage:");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
            } else
            {
                Console.WriteLine("This id noes exist!");
            }

            Console.WriteLine("Update list of employees: ");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
