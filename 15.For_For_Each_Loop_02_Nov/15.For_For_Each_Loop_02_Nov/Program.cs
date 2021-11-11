using System;

namespace _15.For_For_Each_Loop_02_Nov
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] Numbers = new int[3];

            //Numbers[0] = 101;
            //Numbers[1] = 102;
            //Numbers[2] = 103;
            ////to check how many elements are there in the array
            //Console.WriteLine($"The Total number of elements in the Array is {Numbers.Length}");

            //string[] Names = new string[3];

            //Names[0] = "Manthan";
            //Names[1] = "Moni";
            //Names[2] = "Pranav";


            //foreach (string k in Names)
            //{
            //    Console.WriteLine(k);
            //}

            //for (int j = 0; j < Numbers.Length; j++)
            //{
            //    Console.WriteLine(Numbers[j]);
            //}

            //int i = 0;
            //while (i < Numbers.Length)
            //{
            //    Console.WriteLine(Numbers[i]);
            //    i++;
            //}


            //How to use break in a loop

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                    continue;
                
                Console.WriteLine(i);
            }
            Console.WriteLine("Limit Reached!");


        }
    }
}
