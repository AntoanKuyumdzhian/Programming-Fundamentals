namespace Revers_Array_of_Integers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            var arrayOfNumbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(arrayOfNumbers);
            Console.WriteLine(string.Join(" ",arrayOfNumbers));
        }
    }
}
