﻿using System;

namespace _13.Loops_11_Nov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your target");

            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= UserTarget)
            {
                Console.Write(Start + " ");
                Start += 2;
            }
        }
    }
}
