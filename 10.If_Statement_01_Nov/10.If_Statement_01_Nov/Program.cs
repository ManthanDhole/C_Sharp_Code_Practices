using System;

namespace _10.If_Statement_01_Nov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");

            int Number = int.Parse(Console.ReadLine());

            if (Number == 1)
            {
                Console.WriteLine($"The Number is {Number}");
            }
            
            else if (Number == 2)
            {
                Console.WriteLine($"The Number is {Number}");
            }

            else if(Number == 3)
            {
                Console.WriteLine($"The Number is {Number}");
            }

            else if(Number == 4)
            {
                Console.WriteLine($"The Number is {Number}");
            }

            else
            {
                Console.WriteLine($"Your Number {Number} is not between 1,2,3");
            }
        }
    }
}
