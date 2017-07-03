namespace _4.Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }
                                , StringSplitOptions.RemoveEmptyEntries)
                                .ToList();

            var lowerCase = text.Where(x => x == x.ToLower() && x.All(char.IsLetter)).ToList();
            text.RemoveAll(x => x == x.ToLower() && x.All(char.IsLetter));

            var upperCase = text.Where(x => x == x.ToUpper() && x.All(char.IsLetter)).ToList();
            text.RemoveAll(x => x == x.ToUpper() && x.All(char.IsLetter));

            Console.WriteLine($"Lower-case: {string.Join(", ",lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", text)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
