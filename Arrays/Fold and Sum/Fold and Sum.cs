namespace Fold_and_Sum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int foldLength = numbers.Length / 4;
            var result = new int[foldLength * 2];
            var lowerSumOfIndex = numbers.Length / 2 - 1;
            var upperSumOfIndex = numbers.Length + lowerSumOfIndex;

            for (int i = 0; i < foldLength; i++)
            {
                result[i] = numbers[foldLength + i] + numbers[lowerSumOfIndex -foldLength - i];
            }

            for (int i = 0; i < foldLength; i++)
            {
                result[foldLength + i] = numbers[foldLength * 2 + i] + numbers[upperSumOfIndex - foldLength * 2 - i];
            }
            Console.WriteLine(string.Join(" ",result));           
        }
    }
}
