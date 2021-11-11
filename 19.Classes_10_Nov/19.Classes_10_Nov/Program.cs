using System;
/* New vocabulary used in C#
1. Data Members - Fields
2. Function - Method / Behaviour  
3. This keyword - Refers to the fields of the same class 
4. Constructor - Used to initialize the fields in a class
5. Default Constructor - Parameterless constructor, gets invoked when no arguements are passed while creating a new instance/object of the class
6. Destructor - Declared using Tilde Symbol (~) to destroy the objects created at the runtime, after the completion of the program execution 
7. Overloading Constructors - Having multiple constructors but different Number and Types of Parameters*/



namespace _19.Classes_10_Nov
{
    class Customer
    {
        //Class Fields
        string _firstName;
        string _lastName;

        //Default Constructor - Used when no arguements are passed to the called constructor
        public Customer() : this("No First Name Provided", "No Last Name Provided")
        {

        }

        //Constructors are used to initialize the class fields and it does not return any value, 
        //A constructor will have the same name as a class hence you can identify easily that a constructor is being used to build up the data members/fields present in the Class
        public Customer(string FirstName, string LastName)
        {
            // 'This' keyword refers to an instance/object of the class
            this._firstName = FirstName;
            _lastName = LastName;
        }

        //Behaviour
        public void PrintFullName()
        {
            Console.WriteLine($"Your Full Name is {this._firstName} {this._lastName}");
        }

        //Destructor
        ~Customer()
        {
            //Clean up code
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Constructors are called automatically when you create an instance of the class and they are used to initialize the Fields in the class
            Customer C1 = new Customer("Manthan", "Dhole");

            //Use the object to call the method in the class
            C1.PrintFullName();

            //Calling the Constructor but not providing any Arguments
            Customer C2 = new Customer();
            C2.PrintFullName();

            

        }
    }
}
