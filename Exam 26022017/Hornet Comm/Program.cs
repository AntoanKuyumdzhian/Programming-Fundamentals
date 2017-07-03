namespace Hornet_Comm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {

            bool end = false;
            var dictMessages = new Dictionary<string, string>();
            var dictBroadcasts = new Dictionary<string, string>();

            while (!end)
            {
                var inputLine = Console.ReadLine();
                var input = inputLine.Split(' ');
                var firstQuery = input[0];
                var secondQuery = input[2];
                if (inputLine == "Hornet is Green")
                {
                    break;
                }

                if (IsPrivate(firstQuery))
                {
                    var massage = firstQuery.ToCharArray().Reverse().ToString();
                    if (!dictMessages.ContainsKey(massage))
                    {
                        dictMessages.Add(massage, secondQuery);
                    }
                }

                if (IsBroadcast(firstQuery))
                {
                    var message = firstQuery.ToCharArray();
                    for (int i = 0; i < message.Length; i++)
                    {
                        if (message[i] >  64 && message[i] < 91)
                        {
                            message[i] = (char)(message[i] + 32);
                        }
                        if (message[i] > 96 && message[i] < 123)
                        {
                            message[i] = (char)(message[i] - 32);
                        }
                        firstQuery = new string(message) ;
                        if (!dictBroadcasts.ContainsKey(firstQuery))
                        {
                            dictBroadcasts.Add(firstQuery, secondQuery);
                        }
                    }
                }

          
            }
            Console.WriteLine($"Broadcasts:");
            if (dictBroadcasts.Count == 0)
            {
                Console.WriteLine($"None");
            }
            foreach (var broadcast in dictBroadcasts)
            {
                Console.WriteLine($"{broadcast.Value} => {broadcast.Key}");
            }
            Console.WriteLine($"Messages:");
            if (dictMessages.Count == 0)
            {
                Console.WriteLine($"None");
            }
            foreach (var message in dictMessages)
            {
                Console.WriteLine($"{message.Key} => {message.Value}");
            }

        }

        public static bool IsPrivate(string query)
        {
            for (int i = 0; i < query.Length; i++)
            {
                char[] tempString = query.ToCharArray();
                if (tempString[i] < 48 && tempString[i] > 57)
                {
                    return false;
                }
            }
            return true; ;
        }

        public static bool IsBroadcast(string query)
        {
            for (int i = 0; i < query.Length; i++)
            {
                char[] tempString = query.ToCharArray();
                if (tempString[i] >= 48 && tempString[i] <= 57)
                {
                    return false;
                }
            }
            return true;
        }
    }
}


