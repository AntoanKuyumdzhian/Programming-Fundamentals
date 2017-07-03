namespace _6.Square_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(n => n).ToArray();
            var counter = 1;
            var previous = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                var current = numbers[i];
                if (current == previous)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{previous} -> {counter}");
                    counter = 1;
                }
                previous = current;
            }

            Console.WriteLine($"{previous} -> {counter}");
        }
    }
}
