using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioListaSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> lista = new List<Employee>();

            Console.WriteLine("How many employees will be registered: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employ #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id tha will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = lista.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This ID does not exist");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees: ");
            foreach (Employee obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
