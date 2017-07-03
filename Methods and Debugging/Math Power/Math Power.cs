namespace Math_Power
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(NumberRaisedToPower(number, power));
        }

        public static double NumberRaisedToPower(double number, double power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return (result);
        }
    }
}
