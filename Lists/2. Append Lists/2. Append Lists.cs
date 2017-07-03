namespace _2.Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            for (int i = 0; i < input.Length; i++)
            {

                var temp = input[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                Console.Write($"{string.Join(" ", temp)} ");
            }
        }
    }
}

