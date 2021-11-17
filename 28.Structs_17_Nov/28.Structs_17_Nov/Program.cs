using System;
//You can use Refactoring to directly ask the Intellisense to create the Property for a Field

//Object Initializer syntax can be used to initialize either Class or Struct

/* Just like classes the Struct can also have 
    1. Private Fields 
    2. Public Properties
    3. Constructors
    4. Methods */
namespace _28.Structs_17_Nov
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(10, "Manthan");
            C1.PrintCustomer();

            Customer C2 = new Customer();
            C2.Id = 12;
            C2.Name = "Dhole";
            C2.PrintCustomer();

            //Object Initializer Syntax
            Customer C3 = new Customer
            {
                //use comma to seperate
                Id = 13,
                Name = "Johhny"
            };
            C3.PrintCustomer();
        }
    }

    public struct Customer
    {
        private int _id;
        private string _Name;

        public int Id { get => this._id; set => this._id = value; }
        public string Name { get => this._Name; set => this._Name = value; }

        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._Name = Name;
        }

        public void PrintCustomer()
        {
            Console.WriteLine($"Id = {this._id} \nName = {this._Name}");
        }

    }
}
