namespace Longer_Line
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double c1 = double.Parse(Console.ReadLine());
            double d1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double c2 = double.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine());

            if (GetLength(a1, b1, c1, d1) < GetLength(a2, b2, c2, d2))
            {
                if (Math.Sqrt(a2 * a2 + b2 * b2) > Math.Sqrt(c2 * c2 + d2 * d2))
                {
                    Console.WriteLine($"({c2}, {d2})({a2}, {b2})");
                }
                else
                {
                    Console.WriteLine($"({a2}, {b2})({c2}, {d2})");
                }
                
            }
            else
            {
                if (Math.Sqrt(a1 * a1 + b1 * b1) > Math.Sqrt(c1 * c1 + d1 * d1))
                {
                    Console.WriteLine($"({c1}, {d1})({a1}, {b1})");
                }
                else
                {
                    Console.WriteLine($"({a1}, {b1})({c1}, {d1})");
                }
            }
        }

        public static double GetLength(double a, double b, double c, double d)
        {
            double firstPoint = 0;
            double secondPoint = 0;
            firstPoint = a - c;
            secondPoint = b - d;
            return Math.Sqrt(firstPoint * firstPoint + secondPoint * secondPoint);
        }
    }
}
