namespace Extract_Middle_1_2_3_Elements
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int pos = nums.Length / 2 -1;
            if (nums.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {nums[pos]}, {nums[pos + 1]} }}");
            }
            else if (nums.Length % 2 != 0 && nums.Length > 1)
            {
                Console.WriteLine($"{{ {nums[pos]}, {nums[pos + 1]}, {nums[pos + 2]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {nums[0]} }}");
            }
        }
    }
}
