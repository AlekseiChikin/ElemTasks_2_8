using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Task_8
{
    public class ConcreteStrategy1 : IStrategy
    {
        private readonly double _goldenRatio;
        public ConcreteStrategy1()
        {
            _goldenRatio = (Math.Sqrt(5) + 1) / 2;

        }
        private void FibToN(int n, List<BigInteger> _sequence)
        {
  
            for (int i = 2; i <= n; i++)
            {
                _sequence.Add(_sequence[i - 2] + _sequence[i - 1]);
            }
        }
      
        public void Algorithm(int len, List<BigInteger> _sequence)
        {
            int end = (int)Math.Pow(10, len);
            FibToN(end, _sequence);
            _sequence = _sequence.Where(x => x.ToString().Length == len).ToList();
            foreach (var item in _sequence)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("ConcreteStrategy1");
        }
        public void Algorithm(int min, int max, List<BigInteger> _sequence)
        {
            
            double newMax = GetElemFromIndex(max);
            FibToN((int)newMax, _sequence);

            _sequence = _sequence.Where(x => x >= min && x <= max).ToList();
            foreach (var item in _sequence)
            {
                Console.Write("{0} ", item);
            }
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
}

