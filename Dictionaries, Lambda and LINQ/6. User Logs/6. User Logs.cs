namespace _6.User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            bool end = false;
            var users = new SortedDictionary<string, List<string>>();

            while (!end)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }
                else
                {
                    var input = inputLine.Split(' ').Reverse().ToList();
                    input.RemoveAt(1);
                    var userName = input[0].Remove(0, 5);
                    var ipAdress = input[1].Remove(0, 3);
                    input[1] = ipAdress;
                    input.RemoveAt(0);

                    if (!users.ContainsKey(userName))
                    {
                        users.Add(userName, input);
                    }
                    else
                    {
                        users[userName].Add(ipAdress);
                    }
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}:");
                for (int i = 0; i < user.Value.Count; i++)
                {
                    int ipCounter = 1;
                    for (int j = i + 1; j < user.Value.Count; j++)
                    {
                        if (user.Value[i] == user.Value[j])
                        {
                            ipCounter++;
                            user.Value.RemoveAt(j);
                            j--;
                        }
                    }
                    if (i < user.Value.Count - 1)
                    {
                        Console.Write($"{user.Value[i]} => {ipCounter}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{user.Value[i]} => {ipCounter}.");
                    }
                    
                }
            }
        }
    }
}
