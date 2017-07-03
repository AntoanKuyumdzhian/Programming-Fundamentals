namespace _3.Big_Factorial
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
