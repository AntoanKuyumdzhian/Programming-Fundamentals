namespace Index_of_Letters
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var word = Console.ReadLine().ToCharArray();

            var letters = new char[26];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)('a' + i); 
            }

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {Array.IndexOf(letters, word[i])}");
            }
        }
    }
}
