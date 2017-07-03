namespace Greater_Value
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if(type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }
        }

        public static int GetMax(int first, int second)
        {
            return (Math.Max(first, second));
        }

        public static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return (first);
            }
            return (second);
        }
        public static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) > 0)
            {
                return (first);
            }
            return (second);
        }
    }
}

