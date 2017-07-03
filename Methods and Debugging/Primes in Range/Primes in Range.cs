namespace Primes_in_Range
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            var primeNumbers = new List<int>();
            Console.WriteLine(string.Join(", ",FindPrimesInRange(startNum, endNum)));
        }

        public static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var tempList = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime && i > 1)
                {
                    tempList.Add(i);
                }
            }

            return tempList;
        }
    }
}
