namespace Largest_Common_End
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var first = Console.ReadLine().Split(' ');
            var second = Console.ReadLine().Split(' ');

            int count = 0;
            int reverseCount = 0;

            if (first.Length <= second.Length)
            {
                count = Counter(first, second);
                Array.Reverse(first);
                Array.Reverse(second);
                reverseCount = Counter(first, second);
            }
            else
            {
                count = Counter(second, first);
                Array.Reverse(first);
                Array.Reverse(second);
                reverseCount = Counter(second, first);
            }
            if (count >= reverseCount)
            {
                Console.WriteLine(count);
            }
            else if(reverseCount > count)
            {
                Console.WriteLine(reverseCount);
            }
            else
            {
                Console.WriteLine("0");
            }
        }

        public static int Counter(string[] smaller, string[] bigger)
        {
            int counter = 0;
            for (int i = 0; i < smaller.Length; i++)
            {
                if (smaller[i] == bigger[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }
    }
}
