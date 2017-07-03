namespace Printing_Triangle
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintTriangle(number);
        }


        public static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintRow(i);
            }
            for (int i = number - 1; i >= 1; i--)
            {
                PrintRow(i);
            }
        }

        public static void PrintRow(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}
