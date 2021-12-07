using System;

namespace Task_8_old.Controllers
{
    class InputFromConsole
    {
        public static(int, int) GetValidRange()
        {
            Console.Write("Enter the range: ");
            string rangeFromUser = Console.ReadLine();

            int firstInRange, lastInRange;

            string[] arr = rangeFromUser.Trim(' ', '[', ']').Split(';', ' ');
            try
            {
                firstInRange = int.Parse(arr[0]);
                lastInRange = int.Parse(arr[1]);

            }
            catch (Exception)
            {
                Console.Write("Pass 2 numeric parameters in the format - \"<range_start> <range_end>\" ,");
                throw;
            }

            return (firstInRange, lastInRange);
        }
        public static int GetValidLenght()
        {
            Console.Write("Enter the lenght : ");

            string lenghtFromUser = Console.ReadLine();

            int validLenght;

            lenghtFromUser = lenghtFromUser.Trim();
            try
            {
                validLenght = int.Parse(lenghtFromUser);
            }
            catch (Exception)
            {
                Console.Write("Type integer ,");
                throw; ;
            }
            
            return validLenght;
        }
    }
}

