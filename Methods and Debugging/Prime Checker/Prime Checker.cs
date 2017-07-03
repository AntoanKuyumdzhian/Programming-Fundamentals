namespace Prime_Checker
{
    using System;

    public class Program
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));

        }

        public static bool IsPrime(long number)
        {
            bool isPrime = true;
            if (number < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            return isPrime;
        }
    }
}
