using System;

//Use the 'new' keyword to hide a base class member of the same name and use the child class member while creating an instance 
//Different ways to invoke a hidden base class member
/* 1. Use the 'base' keyword in the child class
   2. Use the casting of parent class name -> ((Parent)objName).Method();
   3. Use the Parent Class name while creating the object -> Parent objName = new Derived;*/

namespace _22.Method_Hiding_13_Nov
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can also use the Parent class name to create a new object for the Child Class
            Employee FTE = new FullTimeEmployee();
            //FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Manthan";
            FTE.LastName = "Dhole";
            
            //Calling the Employee class method
            //((Employee)FTE).PrintFullName();

            //Calling the FullTimeEmployee class method
            FTE.PrintFullName();


            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Pranav";
            PTE.LastName = "Dhole";
            PTE.PrintFullName();
        }
    }

    class Employee
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    class FullTimeEmployee : Employee
    {
        //Use the 'new' keyword if you want to hide the Parent Class Method and use the Derived class method instead 
        public new void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} - Contractor");

            //To call the base class method you can use the 'base' keyword 
            //base.PrintFullName();
        }
    }

    class PartTimeEmployee : Employee
    {
    }
}
