namespace Hornet_Assault
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var sumHornets = hornets.Sum();

            for (int i = 0; i < beehives.Count(); i++)
            {
                sumHornets = hornets.Sum();
                if (hornets.Count() > 0)
                {
                    if (sumHornets > beehives[i])
                    {
                        beehives.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        beehives[i] -= sumHornets;
                        hornets.RemoveAt(0);
                    }
                }
            }

            if (beehives.Sum() > 0)
            {
                Console.WriteLine(string.Join(" ",beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
