﻿namespace Sign_of_Int_Number
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintSign(number);
        }

        public static void PrintSign(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
