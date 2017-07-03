namespace _1.Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse);
            var counts = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts[number] = 0;
                }
                counts[number]++;
            }
            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
            
        }
    }
}
