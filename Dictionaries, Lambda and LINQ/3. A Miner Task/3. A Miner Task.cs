namespace _3.A_Miner_Task
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var resource = string.Empty;
            long quantity = 0;
            var mine = new Dictionary<string, long>();
            bool end = false; 

            while (!end)
            {
                var input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                else
                {
                    resource = input;
                    quantity = long.Parse(Console.ReadLine());

                    if (!mine.ContainsKey(resource))
                    {
                        mine.Add(resource, quantity);
                    }
                    else
                    {
                        mine[resource] += quantity;
                    }
                }
            }
            foreach (var res in mine)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
