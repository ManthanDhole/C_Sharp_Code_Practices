using System;

/* Method Over-Riding :- A base class reference variable pointing to a child class object, will invoke the overridden method in the Child Class */

/* Method Hiding :- A base class reference variable pointing to a child class object, will invoke the hidden method in the Base Class
  To invoke the derived class method you can 1. Use the 'Cast' method, 2. Create an instance of Derived Class method and then call the Print method */

namespace _24.Method_Overriding_Hiding
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass B = new DerivedClass();
            B.Print();

            ((DerivedClass)B).Print2();


        }
    }

    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("This is a Base Class method");
        }

        public void Print2()
        {
            Console.WriteLine("This is Base Class method Two");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("This is a Derived Class Method");
        }

        public new void Print2() 
        {
            Console.WriteLine("This is a Derived Class method two");
        }
    }
}
