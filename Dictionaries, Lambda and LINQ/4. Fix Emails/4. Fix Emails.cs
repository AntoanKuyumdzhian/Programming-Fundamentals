namespace _4.Fix_Emails
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            bool end = false;
            var emails = new Dictionary<string, string>();
            while (!end == true)
            {
                var name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                var email = Console.ReadLine();

                if (!emails.ContainsKey(name) && !email.EndsWith(".us") && !email.EndsWith(".uk"))
                {
                    emails.Add(name, email);
                }

                if (name == "stop")
                {
                    end = true;
                }
            }

            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
