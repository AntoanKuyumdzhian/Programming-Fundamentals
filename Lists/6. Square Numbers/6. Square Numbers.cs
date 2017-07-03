namespace _6.Square_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).Where(n => Math.Sqrt(n) % 1 == 0).OrderByDescending(n => n).ToList();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
