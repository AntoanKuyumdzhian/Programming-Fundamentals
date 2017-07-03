namespace Max_Sequence_of_Increasing_Elements
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long pos = 0;
            long prevCounter = 1;
            long currCounter = 1;

            for (long i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    currCounter++;
                }
                else
                {
                    currCounter = 1;
                }
                if (currCounter > prevCounter)
                {
                    prevCounter = currCounter;
                    pos = i;
                }
            }
            for (long i = pos - (prevCounter - 1); i <= pos; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

        }
    }
}
