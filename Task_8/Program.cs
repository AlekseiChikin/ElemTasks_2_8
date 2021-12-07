using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Diagnostics;

namespace Task_8
{
    
    class Program
    {
        //TODO move to mvc
        //TODO what is model in this task??
        //TODO move user output in dll
        //TODO add ascii picture
        //TODO diagnostics
       
        
        static void Main(string[] args)
        {
            IStrategy[] strategys = { new ConcreteStrategy1(), new ConcreteStrategy2(), new ConcreteStrategy3() };
            FibonacciNumbers fibonacciNumbers;

           

            fibonacciNumbers = new FibonacciNumbers(strategys[0]);
            fibonacciNumbers.ExecuteAlgorithm(10000, 30000);
            
            fibonacciNumbers = new FibonacciNumbers(strategys[1]);
            //fibonacciNumbers.ExecuteAlgorithm(10000,30000);

            fibonacciNumbers = new FibonacciNumbers(strategys[2]);
            //fibonacciNumbers.ExecuteAlgorithm(10000,30000);

        }          
    }
}
