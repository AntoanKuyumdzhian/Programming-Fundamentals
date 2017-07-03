namespace Hornet_Armada
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Legion
    {
        public string Name { get; set; }
        public int Activity { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            var lineCounter = int.Parse(Console.ReadLine());
            var legions = new List<Legion>();

            for (int i = 0; i < lineCounter; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
                var tempEntry = new Legion();
                tempEntry.Name = input[1];
                tempEntry.Activity = int.Parse(input[0]);
                tempEntry.Type = input[2];
                tempEntry.Count = int.Parse(input[3]);
                legions.Add(tempEntry);

                for (int j = 0; j < legions.Count; j++)
                {
                    if (legions[i].Name != tempEntry.Name && legions[i].Type != tempEntry.Type)
                    {
                        legions.Add(tempEntry);
                    }
                    else
                    {
                        legions[i].Count += tempEntry.Count;
                    }
                }
            }

            var endCommand = Console.ReadLine();
            var soldierType = string.Empty;

            for (int i = 0; i < endCommand.Length; i++)
            {
                if (endCommand[i] == 92)
                {
                    soldierType = endCommand.Substring(i + 1, endCommand.Length); 
                }
            }

            if (soldierType != string.Empty)
            {
                foreach
                var tempRecord = new Lergion;
            }
        }
    }
}

