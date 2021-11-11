using System;

namespace _12.Goto_Jump_Statements_01_Nov
{
    class Program
    {
        static void Main(string[] args)
        {
            int BillAmount = 0;

            Console.WriteLine("Welcome to The Coffee Hub\nSelect which coffee do you want?");
            Start:
            Console.WriteLine("1 - Small, 2 - Medium, 3 - Large");

            int CustChoice = int.Parse(Console.ReadLine());

            switch (CustChoice)
            {
                case 1:
                    BillAmount += 1;
                    break;
                case 2:
                    BillAmount += 2;
                    break;
                case 3:
                    BillAmount += 3;
                    break;
                default:
                    Console.WriteLine("Sorry! Wrong Order");
                    goto Start;

            }

            Decide:
            Console.WriteLine("Do you want to buy more coffee.. Yes/No ??");
            string UserDecision = Console.ReadLine();

            switch(UserDecision.ToLower())
            {
                case "yes":
                    goto Start;
                case "no":
                    break;
                default:
                    Console.WriteLine("Enter Valid Credentials");
                    goto Decide;
            }

            Console.WriteLine("Thank you for visiting!");
            Console.WriteLine($"Your Total Bill is {BillAmount} $");
        }
    }
}
