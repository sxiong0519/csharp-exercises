using System;
using System.Collections.Generic;

namespace Classes
{
    public class Employee
    {

        // Some readonly properties (let's talk about gets, baby)
        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
        public DateTime StartDate { get; }

       
        // Create a public property for holding a list of current employees

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public Employee(string firstName, string lastName, string title, DateTime startDate)
        {
                FirstName = firstName;
                LastName = lastName;
                Title = title;
                StartDate = startDate;
        }

    }
}
