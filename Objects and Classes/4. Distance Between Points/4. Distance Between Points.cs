namespace _4.Distance_Between_Points
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var firstPoint = Console.ReadLine().Split(' ');
            var secondPoint = Console.ReadLine().Split(' ');

            var first = new Point
            {
                X = double.Parse(firstPoint[0]),
                Y = double.Parse(firstPoint[1])
            };
            var second = new Point
            {
                X = double.Parse(secondPoint[0]),
                Y = double.Parse(secondPoint[1])
            };

            Console.WriteLine($"{CalculateDistance(first,second) :F3}");
        }

        public static double CalculateDistance(Point first, Point second)
        {
            var X = Math.Pow(first.X - second.X, 2);
            var Y = Math.Pow(first.Y - second.Y, 2);
            return Math.Sqrt(X + Y);
        }
    }
}
