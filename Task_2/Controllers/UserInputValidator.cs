using System;
using System.Globalization;

namespace Task_2.Controllers
{
    //when static
    static class UserInputValidator //TODO interface validate() 
    {
        
        public static double Parser(string[] enevelopesFromArgs) //for args[] from console
        {
            throw new NotImplementedException();
        }
        public static double GetEnvelopeSide()
        {
            string userInput;
            double result;
            do
            {
                userInput = Console.ReadLine();
                result = ParseToNumeric(userInput);

            } while (double.IsNaN(result));

            return result;
        } //вызываемая после вызываюшей
	public static double ParseToNumeric(string envelopeSide) 
        {
            double result;

            try
            {
                result = double.Parse(envelopeSide);
            }
            catch (Exception) //where declare custom exception(architecture)?
            {
                Console.WriteLine("Invalid data");
                result = double.NaN;
            }
           
            return result;
        }
    }
}
