namespace Center_Point
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (GetDistance(x1, y1) > GetDistance(x2, y2))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }

        public static double GetDistance(double firstCoordinate, double secondCoordinate)
        {
            return Math.Sqrt(firstCoordinate * firstCoordinate + secondCoordinate * secondCoordinate);

        }
    }
}
