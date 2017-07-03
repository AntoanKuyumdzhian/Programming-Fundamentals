namespace _1.Remove_Negatives_and_Reverse
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).Where(n => n > 0).Reverse();
            if (numbers.Count() == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
        }
    }
}
