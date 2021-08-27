using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company friends = new Company("Friends", new DateTime(2012, 05, 09));
            Console.WriteLine(friends.CreatedOn);
            // Create three employees
            Employee employee1 = new Employee("Joey", "Tribbiani", "CEO", new DateTime(2018, 08, 16));
            Employee employee2 = new Employee("Rachel", "Green", "Marketing Dir", new DateTime(2020, 09, 22));
            Employee employee3 = new Employee("Phoebe", "Buffary", "COO", new DateTime(2021, 01, 31));
            Console.WriteLine(employee1.FirstName);
            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}
