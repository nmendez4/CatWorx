// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

namespace CatWorx.Badgemaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string>();
            //collect user values until the value is an empty string
            while (true) {
            Console.WriteLine("Please enter a name: ");
            // get a name from the console and assign it to a variable
            string input = Console.ReadLine() ?? "";
            // break if the user hits enter w/o typing a name
            if (input == "") 
            {
                break;
            }
            employees.Add(input);
            }
            for (int i = 0; i <employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}