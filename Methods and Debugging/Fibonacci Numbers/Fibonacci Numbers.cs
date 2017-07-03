namespace Fibonacci_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FibNumber(number));
        }

        public static int FibNumber(int number)
        {
            int prevFibo = 1;
            int lastFibo = 0;
            int fibNumber = 0;
            for (int i = 0; i <= number; i++)
            {
                fibNumber = prevFibo + lastFibo;
                prevFibo = lastFibo;
                lastFibo = fibNumber;
            }
            return fibNumber;
        }
    }
}
