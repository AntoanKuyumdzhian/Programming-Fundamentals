namespace Array_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int containsInt = -1;
            string commandLine = null;
            int commandLines = 0;
            string command = String.Empty;

            while (commandLine != "print")
            {
                commandLine = Console.ReadLine();
                commandLines++;
                var commandInput = commandLine.Split(' ').ToArray();
                command = commandInput[0];

                switch (command)
                {
                    case "contains":
                        if (numbers.Contains(int.Parse(commandInput[1])))
                        {
                            containsInt = numbers.IndexOf(int.Parse(commandInput[1]));
                            Console.WriteLine(containsInt);
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }
                        break;
                    case "add":
                        for (int i = commandInput.Length - 1; i > 1; i--)
                        {
                            numbers.Insert(int.Parse(commandInput[1]), int.Parse(commandInput[i]));
                        }
                        break;
                    case "addMany":
                        for (int i = commandInput.Length - 1; i > 1; i--)
                        {
                            numbers.Insert(int.Parse(commandInput[1]), int.Parse(commandInput[i]));
                        }
                        break;
                    case "remove":
                        numbers.RemoveAt(int.Parse(commandInput[1]));
                        break;
                    case "shift":
                        var shift = int.Parse(commandInput[1]) % numbers.Count;
                        for (int i = 0; i < shift; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                        break;
                    case "sumPairs":
                        int loops = numbers.Count / 2 - 1;
                        for (int i = 0; i <= loops; i++)
                        {
                            numbers[i] += numbers[i + 1];
                            numbers.RemoveAt(i + 1);
                        }
                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
