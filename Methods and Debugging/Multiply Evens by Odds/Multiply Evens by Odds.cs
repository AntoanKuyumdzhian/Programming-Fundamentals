namespace Multiply_Evens_by_Odds
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfEvens = SumOfDigits(number,0);
            int sumOfOdds = SumOfDigits(number, 1);
            Console.WriteLine(sumOfEvens*sumOfOdds);
        }

        public static int SumOfDigits(int number, int remainder)
        {
            int result = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == remainder)
                {
                    result += digit;
                }
            }
            return (Math.Abs(result));
        }
    }
}
