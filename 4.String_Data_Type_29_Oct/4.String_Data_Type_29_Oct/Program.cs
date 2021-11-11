using System;

namespace _4.String_Data_Type_29_Oct
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello Enter Your Name");
            string Name = "Manthan";

            //Single Quote
            Console.WriteLine($"Hello \'{Name}\'");

            //Double Quotes
            Console.WriteLine($"Hello \"{Name}\"");

            //Backslash in escape sequence
            Console.WriteLine($"Hello \\{Name}\\");

            //Null 
            Console.WriteLine($"Hello \0{Name}\0");

            Console.WriteLine("Do you want to hear something? \nType y/n ");
            string Hear = Console.ReadLine();
            if (Hear == "y")
            {
                //Alert Sound 
                Console.WriteLine($"Hello \'{Name}\a");
            }
            else
            {
                Console.WriteLine("Ok Bye!");
            }

            //Horizontal Tab and Back Space
            Console.WriteLine("Now \twhat?\b");
            
            //Vertical Tab
            Console.WriteLine("Now it is the last \v one");

            //Verbatim Literal
            Console.WriteLine(@"C:\Programs\Files\Microsoft\Visual Studio\vs.exe");




        }
    }
}
