using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
namespace Task_8
{
    class Fibonacci
    {
        private List<BigInteger> _sequence;
        private readonly double _goldenRatio;
        public Fibonacci()
        {
            _goldenRatio = (Math.Sqrt(5) + 1) / 2;
            _sequence = new List<BigInteger>() { 0, 1 };
        }
        public List<BigInteger> GetNthFibonacci(int n) //private
        {
            int number = n ; 
            
            for (int i = 2; i <= number; i++)
            {
                _sequence.Add(_sequence[i - 2] + _sequence[i - 1]);
            }
            return _sequence;
        }
        public IEnumerable<BigInteger> RangeFib(int min, int max)
        {
            return _sequence.Where(x => x >= min && x <= max);
        }
        public IEnumerable<BigInteger> LenghtFib(int len)
        {
            return _sequence.Where(x => x.ToString().Length == len);
        }
        public double GetElemFromIndex(double index)
        {
            return Math.Round(Math.Pow(_goldenRatio, index) / Math.Sqrt(5));
        }
        public double GetIndexFromElem(double elem) 
        {
            return Math.Round(Math.Log10(elem * Math.Sqrt(5) + 0.5) / Math.Log10(_goldenRatio));
        }
        public double BinetsFormula(double index)
        {
            return Math.Round((Math.Pow(_goldenRatio, index) - Math.Pow(-_goldenRatio, -index)) / Math.Sqrt(5));
        }
    }
    class Program
    {
    
        static void Main(string[] args)
        {
           

            Fibonacci fibon = new Fibonacci();
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
