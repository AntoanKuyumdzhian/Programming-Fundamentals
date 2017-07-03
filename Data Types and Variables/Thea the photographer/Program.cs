using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_the_photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double pics = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine());
            double uploadTime = double.Parse(Console.ReadLine());

            double totalTime = pics * filterTime;
            double goodPics = Math.Ceiling((pics * filterFactor) / 100.0);
            totalTime += goodPics * uploadTime;
            TimeSpan span = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",span.Days,span.Hours,span.Minutes,span.Seconds);

        }
    }
}
