namespace _5.Bomb_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bomb = bombInput[0];
            int power = bombInput[1];

            while (numbers.Contains(bomb))
            {
                int bombIndex = numbers.IndexOf(bomb);
                int upper = power;
                int lower = power;
                if (bombIndex + power >= numbers.Count - 1)
                {
                    upper = numbers.Count - 1 - bombIndex;
                }
                if (bombIndex - power < 0)
                {
                    lower = bombIndex;
                }
                numbers.RemoveRange(bombIndex - lower, lower + 1 + upper);
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
