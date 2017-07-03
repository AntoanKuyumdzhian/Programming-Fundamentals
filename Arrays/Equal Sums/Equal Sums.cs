namespace Equal_Sums
{
    using System;
    using System.Linq;

    public class Program
    {
        public static object Select { get; private set; }

        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                long sumAbove = 0;
                long sumBelow = 0;
                for (long i = 0; i < numbers.Length; i++)
                {
                    sumAbove = 0;
                    sumBelow = 0;

                    for (long j = i - 1; j >= 0; j--)
                    {
                        sumBelow += numbers[j];
                    }
                    for (long j = i + 1; j < numbers.Length; j++)
                    {
                        sumAbove += numbers[j];
                    }
                    if (sumAbove == sumBelow)
                    {
                        Console.WriteLine(i);
                        break; ;
                    }
                }
                if (sumAbove != sumBelow)
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
