using System;

namespace _5.Common_Operators_29_Oct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment Operator
            int i = 10;
            Console.WriteLine(i);

            //Arithematic Operators
            int b = 20;

            Console.WriteLine(i + b);
            Console.WriteLine(i - b);
            Console.WriteLine(i * b);
            Console.WriteLine(i / 2);
            Console.WriteLine(i%4);

            //Ternary Operator

            int Number = 10;
            bool IsNumber10 = Number == 10 ? true : false;

            //if (Number == 10)
            //{
            //    IsNumber10 = true;
            //}
            //else
            //{
            //    IsNumber10 = false;
            //}

            Console.WriteLine(IsNumber10);
        }
    }
}
