using System;

namespace _11.Switch_Statement_01_Nov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");

            int UserNumber = int.Parse(Console.ReadLine());

            switch (UserNumber)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine($"The number is {UserNumber}");
                    break;

                default:
                    Console.WriteLine("The number does not exist");
                    break;
            }
        }
    }
}
