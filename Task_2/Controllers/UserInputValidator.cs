using System;

namespace Task_2.Controllers
{
    static class UserInputValidator 
    {
        public static double GetEnvelopeSide()
        {
            string userInput;
            double envelopSide;
            do
            {
                userInput = Console.ReadLine();
                envelopSide = ParseToNumeric(userInput);

            } while (envelopSide <= 0);

            return envelopSide;
        } 
	    public static double ParseToNumeric(string envelopeSide) 
        {
            double result;
            double maxValue = 1_000_000;
            try
            {
                result = double.Parse(envelopeSide);
                
                if (result > maxValue)
                    throw new ArgumentOutOfRangeException();
                if(result <= 0)
                    throw new ArgumentOutOfRangeException();
            }
            catch (Exception) 
            {
                Console.WriteLine("Invalid data");
                Console.WriteLine("Try again, input should be numeric, positive and less than 1 million");
                result = 0;
            }
           
            return result;
        }
    }
}
