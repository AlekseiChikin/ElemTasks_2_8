using System;
using Task_2.Controllers;

namespace Task_2.Views
{
    static class Display
    {
        public static void Welcome()
        {
            //TODO user-friendly
            Console.WriteLine("Hi user");
        }
        public static double[] InteractWithUser()
        {
            double _sideA; //to Model?
            double _sideB;
            double _sideC;
            double _sideD;
            
            Console.Write("Envelop (a, b) side a = ");
            _sideA = UserInputValidator.GetEnvelopeSide();
            Console.WriteLine(_sideA);
            Console.Write("Envelop (a, b) side b = ");
            _sideB = UserInputValidator.GetEnvelopeSide();
            Console.WriteLine(_sideB);
            Console.Write("Envelop (c, d) side c = ");
            _sideC = UserInputValidator.GetEnvelopeSide();
            Console.WriteLine(_sideC);
            Console.Write("Envelop (c, d) side d = ");
            _sideD = UserInputValidator.GetEnvelopeSide();
            Console.WriteLine(_sideD);

            return new double[] { _sideA, _sideB, _sideC, _sideD };
        }//add main-flow or some pattern ? builder mb?
        public static void Footer()
        {
            throw new NotImplementedException();
        }
    }
}
