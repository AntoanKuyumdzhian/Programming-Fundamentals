namespace _2.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static string[] Select { get; private set; }

        public static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(' ');

            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 0;
                }

                dict[word]++;
            }
            var result = new List<string>();
            foreach (var word in dict)
            {
                if (word.Value % 2 != 0)
                {
                    result.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
