namespace Max_Method
{
    using System;

    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(GetMax(num1,num2),GetMax(num2,num3)));
        }

        public static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }
    }
}
