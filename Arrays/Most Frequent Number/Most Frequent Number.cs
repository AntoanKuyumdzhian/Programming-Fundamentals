namespace Most_Frequent_Number
{
    using System;
    using System.Linq;

    public class Program
    {

        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var matrix = new int[65535];
            int max = 0;
            int pointer = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                matrix[numbers[i]]++;
                if (matrix.Max() > max)
                {
                    max = matrix.Max();
                    pointer = Array.IndexOf(matrix, matrix.Max());
                }
            }


            Console.WriteLine(pointer);
        }

    }
}
