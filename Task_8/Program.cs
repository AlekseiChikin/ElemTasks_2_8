using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
namespace Task_8
{
    
    class Program
    {
    
        static void Main(string[] args)
        {
           

            FibonacciNumbers fibon = new FibonacciNumbers();
            List<BigInteger> list = fibon.GetNthFibonacci(100);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            var tmp = fibon.LenghtFib(2);
            Console.WriteLine("====================================");

            foreach (var item in tmp)
            {
                Console.WriteLine(item);
            }

            var qwe = fibon.RangeFib(1, 100);
            Console.WriteLine("====================================");

            foreach (var item in qwe)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(fibon.GetElemFromIndex(100));
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(fibon.GetIndexFromElem(144));
            Console.WriteLine("************************************");
            Console.WriteLine(fibon.BinetsFormula(100));
            
            Console.WriteLine();
;
        }
    }
}
