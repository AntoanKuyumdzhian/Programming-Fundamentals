using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            var temp = 0;
            string output = $"{number} can fit in:\n";

            try
            {
                temp = sbyte.Parse(number);
                output += $"* sbyte\n";
            }
            catch (Exception)
            {
            }
            try
            {
                temp = byte.Parse(number);
                output += $"* byte\n";
            }
            catch (Exception)
            {
            }

            try
            {
                temp = short.Parse(number);
                output += $"* short\n";
            }
            catch (Exception)
            {
            }

            try
            {
                temp = ushort.Parse(number);
                output += $"* ushort\n";
            }
            catch (Exception)
            {
            }

            try
            {
                temp = int.Parse(number);
                output += $"* int\n";
            }
            catch (Exception)
            {
            }
            try
            {
                uint temp1 = uint.Parse(number);
                output += $"* uint\n";
            }
            catch (Exception)
            {
            }
            try
            {
                long temp2 = long.Parse(number);
                output += $"* long\n";
            }
            catch (Exception)
            {
                output = $"{number} can't fit in any type";
            }

            Console.WriteLine(output);


        }
    }
}
