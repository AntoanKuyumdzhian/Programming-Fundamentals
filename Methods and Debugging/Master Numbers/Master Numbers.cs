namespace Master_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (CheckSymmetric(i) && CheckDivisionBy7(i) && CheckForEven(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool CheckSymmetric(int i)
        {
            int number = i;
            int lastDigit = 0;
            int reversed = 0;
            while (i > 0)
            {
                lastDigit = i % 10;
                reversed = reversed * 10 + lastDigit;
                i /= 10;
            }
            if (number == reversed)
            {
                return true;
            }

            return false;
        }

        public static bool CheckDivisionBy7(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }

        public static bool CheckForEven(int i)
        {
            while (i > 0)
            {
                if ((i % 10) % 2 == 0)
                {
                    return true;
                }
                i /= 10;
            }
            
            return false;
        }
    }
}
