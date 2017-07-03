namespace _3.Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            //           var result = new List<int>[];

            for (int i = 0; i < numbers.Count -1; i++)
            {
                for (int j = 0; j < numbers.Count -1; j++)
                {
                    if (numbers[j] == numbers[j + 1])
                    {
                        numbers[j] += numbers[j + 1];
                        numbers.RemoveAt(j + 1);
                        j = -1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
