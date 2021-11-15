using System;
//To over ride a Base class method - Declare it as a Virtual Method and then in the child class write override, this can be used for Polymorphism

/* What is Polymorphism?
    Polymorphism enables us to invoke Derived class methods using a Base class reference variable at Runtime. */

//In the base class the method is Declared as Virtual, and in the child class we Override the same method
//The 'virtual' keyword indicates that a method can be overridden in a derived class
//You cannot use the 'new' keyword in the child class to hide the method of the base class
namespace _23.Polymorphism_15_Nov
{
    class Program
    {
        static void Main(string[] args)
        {
            //We can create an Array of any class
            Employee[] emp = new Employee[4];

            emp[0] = new Employee();
            emp[1] = new PartTimeEmployee();
            emp[2] = new FullTimeEmployee();
            emp[3] = new TemporaryEmployee();

            foreach (Employee e in emp)
            {
                e.PrintFullName();
            }
        }
    }

    //If you just keep the name of the method like that then the child classes are not able to over ride the method described in the Base class
    //Hence to Override the Base class method, you must declare that as a Virtual method
    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        //Now you can override the Base Class method with the Child class method
        //This is called as Polymorphism
        public override void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} - Part time");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} - Full time");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} - Temporary");
        }
    }
}
