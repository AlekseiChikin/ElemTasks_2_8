using System;
using Task_8_old.Controllers;

namespace Task_8_old.Views
{
    static class Display
    {
        private static void Welcome()
        {
            Console.Title = "Fibonacci series";
            Console.WriteLine("Print all Fibonacci numbers that satisfy the constraint passed to the function: are in the specified range, or have specified length.");
        }
        public static void Menu()
        {

            ResultSaver resultSaver = new ResultSaver();
            
            string userChoice;
            int lenght;
            (int, int) range;
            Welcome();
            do
            {
                Console.WriteLine("Enter 1 to pass a range or 2 to pass a length. Enter \"q\" to exit ");
                userChoice = Console.ReadLine();
                try
                {
                    if (userChoice == "1")
                    {
                        range = InputFromConsole.GetValidRange();
                        resultSaver.Add(range);
                        PrintResult(resultSaver, range);
                    }
                    if (userChoice == "2")
                    {
                        lenght = InputFromConsole.GetValidLenght();
                        resultSaver.Add(lenght);
                        PrintResult(resultSaver, lenght);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"try again");
                }

            } while (userChoice != "q");
        }
        private static void PrintResult(ResultSaver resultSaver, int lenght)
        {
            foreach (var item in resultSaver.GetResult().Lenght[lenght])
            {
                Console.WriteLine(item);
            }
        }
        private static void PrintResult(ResultSaver resultSaver, (int, int) range)
        {
            foreach (var item in resultSaver.GetResult().Range[range])
            {
                Console.WriteLine(item);
            }
        }
    }
}
