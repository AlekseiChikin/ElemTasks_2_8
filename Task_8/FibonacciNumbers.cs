using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task_8
{
    class FibonacciNumbers
    {
        private List<BigInteger> _sequence;
        private readonly double _goldenRatio;
        public FibonacciNumbers()
        {
            _goldenRatio = (Math.Sqrt(5) + 1) / 2;
            _sequence = new List<BigInteger>() { 0, 1 };
        }
        public List<BigInteger> GetNthFibonacci(int n) //private
        {
            int number = n;

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
}
