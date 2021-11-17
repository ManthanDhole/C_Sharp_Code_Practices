using System;

/*              Struct                                                     Class
 
  1.          Value Type                                               Reference Type

  2.       Stored on Stack                                             Stored on Heap 

  3.  Hold their value in memory                                    Hold a reference to the    
       where they are stored                                         Object in the Memory

  4. Value types are destroyed immediately                    For Reference types only the Reference           as the scope is lost                      variable is destroyed  after the scope is lost.                                                 The object is later destroyed by the Garbage Collector

  5. When you copy a struct into another struct,           When you copy a class in another class,
    a new copy of the struct is created and             we only get a copy of the reference variable.   modifications on the struct will not affect       Both the reference variables points to the 
    the  values contained by the other struct          same object on the heap. So operation on one
                                                    variable will affect the values contained by the                                         other reference variable. 
 
  6.        Dont have Destructors                                 Can have Destructors

  7.  Cant have explicit parameterless constructors

  8.       Cant inherit from another struct 
     Both struct and class can inherit from interface
 */

//To protect a class from being inherited you can declare the class as a 'Sealed Class' 

namespace _29.Struct_Class_Differences_17_Nov
{
    class Program : Numbers
    {
        static void Main(string[] args)
        {
            //Value Variable
            int i = 10;
            int j = i;
            j = j + 1;

            Console.WriteLine($"{i} {j}");

            Numbers N = new Numbers();
            N.a = 3;
            N.Name = "Manthan";

            Numbers M = N;
            //Reference Variable 
            M.a = 5;
            M.Name = "Dhole";

            Console.WriteLine($"{ N.a } {M.a} {N.Name} {M.Name}");
        }
    }

    public class Numbers 
    {
        public int a { get; set; }
        public string Name { get; set; }


    }
}
