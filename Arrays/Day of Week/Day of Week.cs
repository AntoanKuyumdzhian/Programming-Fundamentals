namespace Day_of_Week
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int day = int.Parse(Console.ReadLine());

            var week = new string[]{ "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday" };
            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(week[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
            
        }
    }
}
