using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Exercício_de_Arrays;

namespace Course
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("How many employees will be registered? ");
            int number = int.Parse(Console.ReadLine());

            List<Employee> funcionarios = new List<Employee>();

            for (int i = 0; i < number; i++)
            {
                int z = 1;
                z = z + i;
                Console.WriteLine("Employee #" + z + ":");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Employee(id, name, salary));

            }

            Console.Write("Enter the employee id that will have salary increase:");
            int searchId = int.Parse(Console.ReadLine());

            Employee increase = funcionarios.Find(x => x.Id == searchId);

            if (increase != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                increase.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This Id does not exist!");
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in funcionarios)
            {
                Console.WriteLine(obj);
            }
        }
    }
}