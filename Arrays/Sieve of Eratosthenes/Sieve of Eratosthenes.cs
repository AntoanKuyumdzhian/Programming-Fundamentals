namespace Sieve_of_Eratosthenes
{
    using System;

    public class Program
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            var numArray = new bool[number + 1];

            for (long i = 2; i < numArray.Length; i++)
            {
                if (!numArray[i])
                {
                    Console.Write($"{i} ");
                    for (long j = i + 1; j < numArray.Length; j++)
                    {
                        if (j % i == 0)
                        {
                            numArray[j] = true;
                        }
                    }
                }
            }

            Console.WriteLine("\n");
        }
    }
}

