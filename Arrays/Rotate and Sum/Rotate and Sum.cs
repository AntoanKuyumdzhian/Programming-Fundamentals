namespace Rotate_and_Sum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = int.Parse(Console.ReadLine());

            int length = numbers.Length;
            var rotated = new int[length];
            var result = new int[length];

            for (int i = 1; i <= count; i++)
            {
                rotated[0] = numbers[length - 1];
                result[0] += rotated[0];
                for (int j = 1; j < length; j++)
                {
                    rotated[j] = numbers[j - 1];
                    result[j] += rotated[j];
                    numbers[j - 1] = rotated[j - 1];
                }
                numbers[length-1] = rotated[length-1];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
