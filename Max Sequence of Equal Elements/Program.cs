namespace Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int startOfSequence = 0;
            int countOfSequence = 0;
            int tempCount = 1;

            for (int i = numbers.Count - 1; i > 0; i--)
            {
                if (numbers[i] == numbers[i-1])
                {
                    tempCount++;
                }
                else
                {
                    tempCount = 1;
                }
                if (tempCount >= countOfSequence)
                {
                    countOfSequence = tempCount;
                    startOfSequence = i - 1;
                }
            }
            var output = new List<int>(numbers.GetRange(startOfSequence, countOfSequence));
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
