using System;

namespace _16.Methods_in_C_sharp_08_Nov
{
    class Program
    {
        static void Main()
        {
            //2 types of methods : Static and Instance Method
            //for calling static method we dont need to create any instance of the Class
            //Eg: ClassName . MethodName();

            //for calling Instance method we need to make an object of the class
            //Eg: ClassName objName = new ClassName();
            //    objName . MethodName();

            //Program p = new Program();
            //p.EvenNumbers(30);

            //Program.EvenNumbers();

            Program add = new Program();
            int Total = add.AddNumbers(3, 7);
            Console.WriteLine(Total);

        }

        public int AddNumbers(int FirstNum, int SecondNum)
        {
            return FirstNum + SecondNum;
        }
        
        public void EvenNumbers(int EndNumber)
        {
            int Start = 0;

            while (Start <= EndNumber)
            {
                if (Start % 2 == 0)
                {
                    Console.WriteLine(Start);
                }
                Start = Start + 1;
            }
        }
    }
}

