using System;

namespace _21.Inheritance_13_Nov
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Bharud";
            FTE.LastName = "Bharti";
            FTE.YearlySalary = 500000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Chammak";
            PTE.LastName = "Challo";
            PTE.HourlyRates = 500;
            PTE.PrintFullName();

            Extra E = new Extra();
            E.FirstName = "Dont";
            E.LastName = "Know";
            E.HourlyRates = 90;
            E.PrintFullName();
        }
    }

    //Parent Class
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        //Multiple Constructors
        public Employee()
        {
            Console.WriteLine("ParentClass Constructor Called");
        }

        public Employee(string Message)
        {
            Console.WriteLine(Message);
        }

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    //Derived Class
    //Inheritance is in use here
    //The properties of the Employee class can be accessed by the FullTimeEmployee and PartTimeEmployee classes
    //These classes are called as Child Class or Derived class.
    //Inheritance helps us to reduce code repetition and the code can be reused by the derived classes.
    
    class FullTimeEmployee : Employee
    {
        public float YearlySalary;

        //In order to call a specific constructor, you can define which one to call by using the 'base' keyword
        public FullTimeEmployee() :base("Hellow there")
        {
            Console.WriteLine("ChildClass Constructor called");
        }
    }


    //     Derived Class : Employee Class
    class PartTimeEmployee : Employee //, Extra
    {
        public float HourlyRates;
    }

    //C# does not support Multiple Inheritance but it supports MultiLevel Inheritance
    class Extra : PartTimeEmployee
    {
        //Code goes here
    }
}
