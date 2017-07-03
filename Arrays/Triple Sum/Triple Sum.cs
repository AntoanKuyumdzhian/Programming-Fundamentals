namespace Triple_Sum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string output = "No";
            for (long i = 0; i < numbers.Length - 1; i++)
            {
                for (long j = i+1; j < numbers.Length; j++)
                {
                    for (long k = 0; k < numbers.Length; k++)
                    {
                        if (numbers[i] + numbers[j] == numbers[k])
                        {
                            output = $"{numbers[i]} + {numbers[j]} == {numbers[k]}";
                            Console.WriteLine(output);
                            break;
                        }
                    }
                }
            }
            if (output == "No")
            {
                Console.WriteLine(output);
            }
        }
    }
}
