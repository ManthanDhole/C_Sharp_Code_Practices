using System;

namespace _3.Data_Types_in_C_Sharp
{
    class Program
    {
        static void Main()
        {
            //Boolean only have True or False values    
            //bool b = false;
            //Console.WriteLine("The value of the Boolean is {0}", b);

            Console.WriteLine("Print the sizes of all the Data Types");
            
            Console.WriteLine($"Minimum value of Interger {int.MinValue}");
            Console.WriteLine($"Maximum value of Interger {int.MaxValue}");

            Console.WriteLine($"The range of Boolean is {bool.TrueString} and {bool.FalseString}");

            Console.WriteLine($"The range of Short Integer is {short.MinValue} and {short.MaxValue}");

            Console.WriteLine($"The range of a Byte is {byte.MinValue} and {byte.MaxValue}");

            Console.WriteLine($"The range of Long Integer is {long.MinValue} and {long.MaxValue}");

            Console.WriteLine($"The range of Unsigned Long Integer is {ulong.MinValue} and {ulong.MaxValue}");

            Console.WriteLine($"The range of Float is {float.MinValue} and {float.MaxValue}");

            Console.WriteLine($"The range of Double is {double.MinValue} and {double.MaxValue}");

            Console.WriteLine($"The range of Decimal is {decimal.MinValue} and {decimal.MaxValue}");
        }
    }
}
