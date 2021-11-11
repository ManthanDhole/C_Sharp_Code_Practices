using System;

namespace _6.Nullabe_Types_31_Oct
{
    class Program
    {
        static void Main()
        {
            //You can convert a non nullable type into nullable type by using a Question mark (?) while Declaring the variable.

            //bool? AreYouMajor = null;

            //Console.WriteLine("Tell me.. Are you a Major? \nYes/No");
            //string Answer = Console.ReadLine();

            //if (Answer == "Yes")
            //{
            //    AreYouMajor  = true;
            //    Console.WriteLine("You are a Major");
            //}
            //else if (Answer == "No")
            //{
            //    AreYouMajor = false;
            //    Console.WriteLine("You are not a Major");
            //}
            //else
            //{
            //    Console.WriteLine("You Did not answered");
            //}


            // Tickets example

            int? TicketsOnSale = null;

            //Null Coalescing Operator ??
 
            int AvailableTickets = TicketsOnSale ?? 0;

            //The following If statement can be merged into a single line by using Null Coalesing Operator ??

            //if (TicketsOnSale == null)
            //{
            //    AvailableTickets = 0;
            //}
            //else
            //{
            //    AvailableTickets = (int)TicketsOnSale;
            //}

            Console.WriteLine($"How lucky you are that Available Tickets are {AvailableTickets}");
        }
    }
}
