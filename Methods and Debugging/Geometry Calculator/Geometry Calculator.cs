namespace Geometry_Calculator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string type = Console.ReadLine();
            GetArea(type);

        }

        public static void GetArea(string type)
        {
            double side = 0;
            double height = 0;
            double width = 0;
            double radius = 0;

            switch (type)
            {
                case "triangle":
                    side = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}",GetTriangleAre(side, height));
                    break;

                case "square":
                    side = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", GetSquareArea(side));
                    break;

                case "rectangle":
                    width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", GetRectangleArea(width, height));
                    break;
                case "circle":
                    radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", GetCircleArea(radius));
                    break;
            }
        }

        public static double GetTriangleAre(double side, double height)
        {
            return side * height / 2;
        }
        public static double GetSquareArea(double side)
        {
            return side * side;
        }
        public static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
        public static double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        
    }
}
