namespace Compare_Char_Arrays
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var firstString = Console.ReadLine();
            var secondString = Console.ReadLine();

            
            if (string.Compare(firstString, secondString) <= 0)
            {
                Console.WriteLine(string.Join(" ", firstString).Replace(" ", ""));
                Console.WriteLine(string.Join(" ", secondString).Replace(" ", ""));
            }
            else
            {
                Console.WriteLine(string.Join(" ", secondString).Replace(" ", ""));
                Console.WriteLine(string.Join(" ", firstString).Replace(" ", ""));
            }
        }
    }
}
