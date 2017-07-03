namespace Reverse_Array_of_Strings
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            Array.Reverse(input);
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
