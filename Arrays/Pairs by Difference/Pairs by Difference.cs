namespace Pairs_by_Difference
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var differense = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == differense)
                    {
                        counter++;
                    }
                }
            }
            if (counter > 0)
            {
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
