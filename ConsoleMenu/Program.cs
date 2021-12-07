using System;
using System.Collections.Generic;


namespace ConsoleMenu
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Action> dict = new();

            dict.Add("2", Task_2.Program.Main);
            dict.Add("3", Task_3.Program.Main);
            dict.Add("8", Task_8_old.Program.Main);

            string userInput;
            do
            {
                Console.WriteLine("============================================");
                Console.Title = "Menu";
                Console.WriteLine("Enter Task Number (2 , 3 , 8) or \"q\" to exit");
                userInput = Console.ReadLine();
                if (dict.ContainsKey(userInput))
                {
                    dict[userInput].Invoke();
                }
            } while (userInput!="q");

        }
    }
}
