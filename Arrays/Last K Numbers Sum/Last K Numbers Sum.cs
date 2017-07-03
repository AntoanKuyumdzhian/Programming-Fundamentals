namespace Last_K_Numbers_Sum
{
    using System;

    public class Program
    {

        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            var numbers = new long[n];
            numbers[0] = 1;

            for (long i = 1; i < n; i++)
            {
                for (long j = i-1; j >= i-k; j--)
                {
                    if (j >= 0)
                    {
                        numbers[i] += numbers[j];
                    }
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
