using System;
using System.Collections.Generic;

namespace Task_3.Views
{
    class Display
    {
        private static void Welcome()
        {
            Console.Title = "Sorting triangles";
            Console.WriteLine("Console program that displays triangles in descending order of area." +
                " After adding each new triangle, the program asks if the user wants to add another one." +
                " If the user answers “y” or “yes”, the program will ask you to enter data for one more triangle," +
                " otherwise it outputs the result to the console.");
        }
        public static void Menu()
        {
            string[] userInputRaw = new string[4];
            string triangleName;
            double sideA, sideB, sideC;
            Triangle triangle;
            List<Triangle> listTriangles = new List<Triangle>();
            string userChoice;
            do
            {
                Console.WriteLine("Enter a triangle in the format <name>, <side length>, <side length>, <side length>. The triangle must be real");

                try
                {
                    userInputRaw = Console.ReadLine().Split(',');
                    triangleName = userInputRaw[0].Trim().ToLower();
                    sideA = Double.Parse(userInputRaw[1]);
                    sideB = Double.Parse(userInputRaw[2]);
                    sideC = Double.Parse(userInputRaw[3]);
                    triangle = Triangle.Factory.Create(triangleName, sideA, sideB, sideC);
                }
                catch (Exception)
                {
                    Console.WriteLine("Something get wrong, try again");
                    triangle = null;
                }

                if (triangle != null)
                {
                    listTriangles.Add(triangle);
                    Console.WriteLine("Triangle added");
                }
                else
                {
                    Console.WriteLine("Triangle invalid");
                }
                Console.WriteLine("Another one ?(y/n) ");
                userChoice = Console.ReadLine().ToLower();
            } while (userChoice.ToLower() != "n");
            
            PrintSortedListOfTriangles(listTriangles);
        }
        private static void PrintSortedListOfTriangles(List<Triangle> listTriangles)
        {
            listTriangles.Sort();
            Console.WriteLine("============= Triangles list: ===============");
            for (int i = 0; i < listTriangles.Count; i++)
            {
                Console.WriteLine($"{i+1}. [Triangle {listTriangles[i].Name}]: {Math.Round(listTriangles[i].Area, 2)} cm");
            }
        }
    }
}
