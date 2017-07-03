namespace _5.Sort_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).OrderBy(n => n).ToList();
            Console.WriteLine(string.Join(" <= ",numbers));
        }
    }
}
