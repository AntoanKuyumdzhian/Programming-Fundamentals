namespace Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int prevCounter = 1;
            int currCounter = 1;
            int pos = 0;

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currCounter++;
                }
                else
                {
                    currCounter = 1;
                }

                if (currCounter >= prevCounter)
                {
                    prevCounter = currCounter;
                    pos = i - 1;
                }
            }

            for (int i = pos; i < pos + prevCounter; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
