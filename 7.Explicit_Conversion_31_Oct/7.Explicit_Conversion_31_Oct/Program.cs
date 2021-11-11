using System;

namespace _7.Explicit_Conversion_31_Oct
{
    class Program
    {
        static void Main()
        {
            //float f = 100232133123123123.234f;
            //int i = (int)f;

            //Console.WriteLine(i);


            string str = "100";
            int result = 0;
            //int i = int.Parse(str);

            //Try parse returns boolean value. Hence use the following method   

            bool IsParseSuccess = int.TryParse(str, out result);
            
            if (IsParseSuccess)
            {
                Console.WriteLine(result);
            }
            else if(!IsParseSuccess)
            {
                Console.WriteLine("Enter a valid number");
            }

        }
    }
}
