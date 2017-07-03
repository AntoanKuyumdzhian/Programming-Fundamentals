namespace _2.Randomize_Words
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            var random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                var temp = input[i];
                var randomIndex = random.Next(0, input.Length);

                input[i] = input[randomIndex];
                input[randomIndex] = temp;
            }
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
