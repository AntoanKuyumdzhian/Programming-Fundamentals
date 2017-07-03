namespace Filled_Square
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintDashes(number);
            for (int i = 0; i < number - 2; i++)
            {
                PrintBodyLine(number);
            }
            PrintDashes(number);
        }

        public static void PrintDashes(int number)
        {
            Console.WriteLine(new string ('-',number * 2));
        }

        public static void PrintBodyLine(int number)
        {
            Console.Write("-");
            for (int i = 1; i < number; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
