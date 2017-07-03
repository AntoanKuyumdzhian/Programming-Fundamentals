namespace _3.Sum__Min__Max__Average
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = int.Parse(Console.ReadLine());
            var listNumbers = new List<int>();

            for (int i = 0; i < numbers; i++)
            {
                listNumbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Sum = {listNumbers.Sum()}");
            Console.WriteLine($"Min = {listNumbers.Min()}");
            Console.WriteLine($"Max = {listNumbers.Max()}");
            Console.WriteLine($"Average = {listNumbers.Average()}");
        }
    }
}
