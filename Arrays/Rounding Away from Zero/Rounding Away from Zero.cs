namespace Rounding_Away_from_Zero
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
