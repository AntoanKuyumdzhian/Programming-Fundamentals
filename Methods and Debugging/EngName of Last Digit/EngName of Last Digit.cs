namespace EngName_of_Last_Digit
{
    using System;

    public class Program
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            number = GetLastNumber(number);
            string[] verbalNums = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            Console.WriteLine(verbalNums[GetLastNumber(number)]);

        }

        public static long GetLastNumber(long tempNumber)
        {
            return Math.Abs(tempNumber % 10);
        }
    }
}