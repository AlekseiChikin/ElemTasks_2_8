using System;
using Task_2.Controllers;
using Task_2.Views;
using Task_2.Models;

namespace Task_2
{
    class Program
    {
       
        static void Main()
        {
        
            Display.Welcome();
            double[] sides = Display.InteractWithUser(); 

            Envelope env1 = new Envelope(sides[0], sides[1]); //move to EnvelopComparer
            Envelope env2 = new Envelope(sides[2], sides[3]);


            if ((env1.CompareTo(env2) == 1))// move to Display
            {
                Console.WriteLine("first envelope biger");
            }
            else
            {
                Console.WriteLine("second envelope biger");
            }
            

        }

    }
}