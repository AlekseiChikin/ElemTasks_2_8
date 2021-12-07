using System;
using Task_2.Controllers;
using Task_2.Models;

namespace Task_2.Views
{
    static class Display
    {
        public static void Welcome()
        {
            Console.Title = "Analysis of envelopes";
            Console.WriteLine("Two envelopes with sides (a, b) and (c, d) find out if one envelope can be nested inside the other. " +
                "Program asks user for the envelope sizes one parameter at a time." +
                " After each calculation, program asks user if he wants to continue." +
                " If he answers  “y”  or  “yes” , the program continues from the beginning, otherwise it exits.");
        }
        public static double[] InteractWithUser()
        {
            double sideA; 
            double sideB;
            double sideC;
            double sideD;
            
            Console.Write("Envelop (a, b) side a = ");
            sideA = UserInputValidator.GetEnvelopeSide();
            Console.WriteLine($"Side a = {sideA}");
            Console.Write("Envelop (a, b) side b = ");
            sideB = UserInputValidator.GetEnvelopeSide();
            Console.WriteLine($"Side b = {sideB}");
            Console.Write("Envelop (c, d) side c = ");
            sideC = UserInputValidator.GetEnvelopeSide();
            Console.WriteLine($"Side c = {sideC}");
            Console.Write("Envelop (c, d) side d = ");
            sideD = UserInputValidator.GetEnvelopeSide();
            Console.WriteLine($"Side d = {sideD}");

            return new double[] { sideA, sideB, sideC, sideD };
        }
        public static void Menu()
        {
            Welcome();
            string userInput;
            double[] envelopesSides;
            do
            {
                envelopesSides = Display.InteractWithUser();

                Envelope env1 = new Envelope(envelopesSides[0], envelopesSides[1]);
                Envelope env2 = new Envelope(envelopesSides[2], envelopesSides[3]);

                EnvelopeInserter<BasicStrategy> EnvInserter = new EnvelopeInserter<BasicStrategy>(env1, env2);

                Console.WriteLine($"Can envelope be inserted into another envelope = {EnvInserter.Insertable()}");
                Console.WriteLine("Try one more time ? Type “y”  or  “yes” to continue,  otherwise program closed");
                userInput = Console.ReadLine().Trim().ToLower();
            } while (userInput == "y" || userInput == "yes");
        }
    }
}
