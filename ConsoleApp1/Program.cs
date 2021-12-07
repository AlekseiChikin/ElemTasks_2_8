using System;
using System.Collections.Generic;
using Task_2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) // dotnet run consoleApp1 task_2 [2;10]
        {
            //Func<int, double>
            Dictionary<string, Action<string[]>> dict = new Dictionary<string, Action<string[]>>();
            dict.Add("task2", Main);
            do
            {

            }while (true);
        }
    }
}
