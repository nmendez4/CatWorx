// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

namespace CatWorx.Badgemaker
{
        class Program
    {
    static List<Employee> GetEmployees()
    {
        List<Employee> employees = new List<Employee>();
        while (true)
        {

        Console.WriteLine("Please enter a name: (leave empty to exit): ");

        string input = Console.ReadLine() ?? "";

        if (input == "")
        {
            break;
        }
        // create new employee instance
        Employee currentEmployee = new Employee(input, "Smith");
        // add currentEmployee, not a string
        employees.Add(currentEmployee);
        }
        return employees;
    }

    static void PrintEmployees(List<string> employees)
    {
        for (int i = 0; i < employees.Count; i++)
        {
        Console.WriteLine(employees[i]);
        }
    }

    static void PrintEmployees(List<Employee> employees)
    {
        List<string> employees = GetEmployees();
        PrintEmployees(employees);
    }
    }
}