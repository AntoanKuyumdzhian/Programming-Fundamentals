namespace _4.Sum_Reversed_Numbers
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToArray();
            var digits = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                var temp = new string(numbers[i].ToCharArray().Reverse().ToArray());
                digits[i] = int.Parse(temp);
            }
            Console.WriteLine(digits.Sum());


        }
    }
}
