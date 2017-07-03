namespace Factorial_Triling_Zeros
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            BigInteger lastNumber = 0;
            int zeroCount = 0;
            do
            {
                lastNumber = result % 10;
                if (lastNumber == 0)
                {
                    zeroCount++;
                }
                result /= 10;
            }
            while (lastNumber == 0);

            Console.WriteLine(zeroCount);
        }
    }
}
