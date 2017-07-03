namespace _5.Short_Words_Sorted
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower()
                .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w);
            Console.WriteLine(string.Join(", ",text));
        }
    }
}
