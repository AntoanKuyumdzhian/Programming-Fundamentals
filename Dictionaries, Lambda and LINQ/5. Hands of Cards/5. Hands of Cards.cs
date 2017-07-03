namespace _5.Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            bool end = false;
            var players = new Dictionary<string, List<string>>();
            while (!end)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "JOKER")
                {
                    break;
                }
                var name = inputLine.Substring(0, inputLine.IndexOf(':'));
                var tempString = inputLine.Remove(0, inputLine.IndexOf(':'));
                var cardsLine = tempString.Split(new[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

                if (!players.ContainsKey(name))
                {
                    players.Add(name, cardsLine);
                }
                else
                {
                    for (int i = 0; i < cardsLine.Count; i++)
                    {
                        if (!players[name].Contains(cardsLine[i]))
                        {
                            players[name].Add(cardsLine[i]);
                        }
                    }
                }
            }

            foreach (var player in players)
            {
                int results = 0;
                for (int i = 0; i < player.Value.Count; i++)
                {
                    results += CalcValueOfCard(player.Value[i]);
                }
                Console.WriteLine($"{player.Key}: {results}");
            }
        }
        public static int CalcValueOfCard(string card)
        {
            var power = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            var type = new string[] { "", "C", "D", "H", "S" };
            var cardPower = Array.IndexOf(power, card.Substring(0,card.Length - 1));
            var cardType = Array.IndexOf(type, card.Substring(card.Length - 1,1));
            var result = cardPower * cardType;

            return cardPower * cardType;
        }
    }
}
