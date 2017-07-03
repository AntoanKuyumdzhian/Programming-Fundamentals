namespace Triangle_Area
{
    using System;
    public class Program
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(TriangleArea(width, height));

        }

        public static double TriangleArea(double width, double height)
        {
            return (width * height) / 2;
        }
    }
}
