using System;

//Function Overloading and Method overloading are the same terms used interchangeably

//Method overloading allows a class to have multiple methods of the Same Name, but with Different Signatures.
//We can overload a method based on Number, Type(int, float, double, string) and Kind(Value, Ref, Out) of parameters

/* What is a Signature of the Method? 
    It consists of the Name of the method, the Type, Number and Kind of the Parameter
    The signature of a method does not include the Return Type and the Params modifier, so it is not possible to overload a method based on Return type and Params Modifier*/
namespace _25.Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int addi;
            Add(1, 3, out addi);

            Console.WriteLine(addi);
        }

        public static void Add(int FN, int SN, out int sum)
        {
            Console.WriteLine($"{FN + SN}");
            sum = FN + SN;
        }
        public static void Add(float FN, float SN)
        {
            Console.WriteLine($"{FN + SN}");
        }
    }
}
