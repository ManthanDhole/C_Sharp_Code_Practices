using System;

//Static members are invoked using the Class Name whereas Instance members are invoked using instance of the class(Object Reference)

namespace _20.Static_and_Instance_Class_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            Console.WriteLine(c.CalculateArea());

            //You cannot use an instance to call the static function, you'll need the name of the class to call the static function altogether
            
            Circle.PrintDiameter();
        }
    }

    //Any class member (fields, constructors, methods, delegates) could be of 2 types
    //Static member or Instance members
    //The main difference between static and instance members is that an instance member will be duplicated each time when an object is created, but if we mention something as static which would be used each time with the same value, then this static member will not be copied/ duplicated again and again which will save the memory.
    class Circle
    {
        static float _PI;
        int _Radius;

        //Static constructor
        static Circle()
        {
            Console.WriteLine("Static Constructor Called");
            Circle._PI = 3.142f;
        }

        //When you dont give 'public' access modifier to a constructor then it is default as 'Private' member
        public Circle(int Radius)
        {
            Console.WriteLine("Instance Constructor Called");
            this._Radius = Radius;
        }

        public float CalculateArea()
        {
            //Once you make a field as static, you cannot use 'this' keyword for that member, because 'this' keyword refers to an instance of the class
            //return this._PI * this._Radius * this._Radius;
            
            //you can refer the static member by the Name of the Class itself
            //you dont use an object to mention a field of the class.
            //hence c1.PI, c2.PI is not permissible. Instead use Circle.PI to refer to the static member.
            return Circle._PI * this._Radius * this._Radius;
        }

        public  static void PrintDiameter()
        {
            //You cannot use 'this' keyword in the static method
           // return 2 * this._Radius;

        }
    }
}
