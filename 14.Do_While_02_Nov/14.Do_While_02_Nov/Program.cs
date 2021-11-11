using System;

namespace _14.Do_While_02_Nov
{
    class Program
    {
        static void Main(string[] args)
        {
            string Choice = string.Empty;
            do
            {
                Console.WriteLine("Please enter your target");

                int Target = int.Parse(Console.ReadLine());

                int Start = 0;

                while (Start <= Target)
                {
                    Console.WriteLine(Start);
                    Start += 2;
                }


                do
                {
                    Console.WriteLine("Do you want to do it again? \nYes/No");
                    Choice = Console.ReadLine().ToLower();

                    if (Choice != "yes" && Choice != "no")
                    {
                        Console.WriteLine("Invalid answer!");
                    }
                }
                while (Choice != "yes" && Choice != "no");
            }
            while (Choice == "yes");



        }
    }
}
