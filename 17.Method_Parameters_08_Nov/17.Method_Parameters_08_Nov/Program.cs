using System;

//4 types of parameters

//1. Value Parameters
//2. Reference Parameters
//3. Output Parameters
//4. Parameter Arrays

namespace _17.Method_Parameters_08_Nov
{
    class Program
    {
        //Value Parameters and Reference Parameters

        //static void Main()
        //{
        //    int i = 10;

        //   // ChangeNumber(i);   Pass by Value
        //    ChangeNumber(ref i);    //Pass by reference

        //    Console.WriteLine(i);
        //}
        ////When you use 'ref' keyword before passing the parameter, it acts as a Pointer to the Location of the i variable
        //public static void ChangeNumber(ref int j)
        //{
        //    j = 20;
        //}

        //Out Parameters (Output parameters)

        //static void Main()
        //{
        //    int Sum;
        //    int Multiply;

        //    //Use out to return the value of the Variable from function to another variable in the Main method
        //    //remember that the method does not returns any specific value, hence it is declared as void 
        //    //And if you want to store the returned value in a Vairable then write the name of the variable after the Out Keyword
        //    Calculate(10, 20, out Sum, out Multiply);
        //    Console.WriteLine($"Addition = {Sum} and Multiplication = {Multiply}");
        //}

        ////Use out keyword to return multiple values 
        ////Use void while declaring the Function
        //public static void Calculate(int FirstNum, int SecondNum, out int Sum, out int Product)
        //{
        //    Product = FirstNum * SecondNum;
        //    Sum = FirstNum + SecondNum;
        //}

        //Parameter Array
        static void Main()
        {
            int[] Numbers = new int[5];

            Numbers[0] = 00;
            Numbers[1] = 10;
            Numbers[2] = 20;
            Numbers[3] = 30;
            Numbers[4] = 40;

            //ParamsMethod(); //You can choose not to pass any parameters here
            //ParamsMethod(Numbers); //You have passed the Numbers Array

            ParamsMethod(1, 2, 3);
        }

        public static void ParamsMethod(params int[] Array)
        {
            Console.WriteLine($"The number of elements in the Array is {Array.Length}");

            foreach (int i in Array)
            {
                Console.WriteLine(i);
            }

        }
    }
}
