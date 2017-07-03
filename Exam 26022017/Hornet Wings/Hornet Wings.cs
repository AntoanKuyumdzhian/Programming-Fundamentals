namespace Hornet_Wings
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var flaps = int.Parse(Console.ReadLine());
            var distancePer1000 = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var metersTraveled = flaps / 1000 * distancePer1000;
            var secondsToFly = flaps / 100;
            var breaks = flaps / endurance;
            var rest = breaks * 5;

            Console.WriteLine($"{metersTraveled:F2} m.");
            Console.WriteLine($"{secondsToFly + rest} s.");
        }
    }
}
