using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_part_of_ASCII_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());

            for (int i = first; i <= last; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.Write("\n");
        }
    }
}
