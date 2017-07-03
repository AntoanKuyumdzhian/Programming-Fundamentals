namespace Nums_in_Revers_Order
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var number = Console.ReadLine();
            Console.WriteLine(ReversedNumber(number));
        }

        public static string ReversedNumber(string number)
        {
            return new string(number.ToCharArray().Reverse().ToArray());
        }
    }
}
