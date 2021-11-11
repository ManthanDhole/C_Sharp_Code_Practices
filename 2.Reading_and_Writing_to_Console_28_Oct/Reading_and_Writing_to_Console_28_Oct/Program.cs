using System;

namespace Reading_and_Writing_to_Console_28_Oct
{
    class Program
    {
        static void Main()
        {
            //Read and write single name

            /* Console.WriteLine("Welcome! Enter your Name");

             string UserName = Console.ReadLine();

             //Console.WriteLine("Hey " + UserName);
             //Console.WriteLine("Hey {0}", UserName);
             Console.WriteLine($"Hey {UserName}");   */

            //Read and Write Your First and Last Name Seperately

            Console.WriteLine("Enter your First Name");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name");
            string LastName = Console.ReadLine();

            Console.WriteLine($"Hey! Welcome {FirstName} {LastName}");
        }
    }
}
