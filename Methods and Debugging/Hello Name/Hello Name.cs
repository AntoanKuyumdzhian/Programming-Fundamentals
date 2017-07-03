namespace Hello_Name
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);
        }

        public static void PrintName(string name)
        {
            System.Console.WriteLine($"Hello, {name}!");
        }
    }
}
