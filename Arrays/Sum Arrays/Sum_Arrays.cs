using System;
using System.Linq;


namespace Sum_Arrays
{
    public class Sum_Arrays
    {
        public static void Main()
        {
            var first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (first.Length >= second.Length)
            {
                Console.WriteLine(string.Join(" ",SumOfArrays(first,second)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", SumOfArrays(second, first)));
            }

            
        }
        public static int[] SumOfArrays(int[] bigger, int[] smaller)
        {
            var result = new int[bigger.Length];
            int counter = 0;
            for (int i = 0; i < bigger.Length; i++)
            {
                if (counter == smaller.Length)
                {
                    counter = 0;
                }
                result[i] = bigger[i] + smaller[counter];
                counter++;
            }
            return result;
        }
    }
}


