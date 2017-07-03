namespace _1.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            bool end = false;

            var phonebook = new SortedDictionary<string, string>();

            while (!end)
            {
                var commandLine = Console.ReadLine().Split(' ');
                var command = commandLine[0];
                var name = string.Empty;
                var phone = string.Empty;


                if (command == "A")
                {
                    name = commandLine[1];
                    phone = commandLine[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, phone);
                    }
                    else
                    {
                        phonebook[name] = phone;
                    }
                }
                else if (command == "S")
                {
                    name = commandLine[1];
                    if (!phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                else
                {
                    end = true;
                }
            }
        }
    }
}
