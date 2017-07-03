namespace Cube_Properties
{
    using System;

    public class Program
    {
        public static double output = 0.0;
        public static void Main()
        {
            double edge = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();
            GetProperty(edge, property);
            Console.WriteLine("{0:F2}", output);
        }

        public static void GetProperty(double edge, string property)
        {
            switch (property)
            {
                case "face":
                    output = GetFace(edge);
                    break;
                case "space":
                    output = GetSpace(edge);
                    break;
                case "volume":
                    output = GetVolume(edge);
                    break;
                case "area":
                    output = GetArea(edge);
                    break;
            }
        }

        public static double GetFace(double edge)
        {
            return edge * Math.Sqrt(2);
        }

        public static double GetSpace(double edge)
        {
            return Math.Sqrt(3 * edge * edge);
        }

        public static double GetVolume(double edge)
        {
            return edge * edge * edge;
        }

        public static double GetArea(double edge)
        {
            return edge * edge * 6;
        }

    }
}
