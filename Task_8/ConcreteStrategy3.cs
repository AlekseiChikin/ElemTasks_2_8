using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class ConcreteStrategy3 : IStrategy
    {
        private List<BigInteger> _sequence;

        public ConcreteStrategy3()
        {   _sequence = new List<BigInteger>() { 0, 1 };
            _sequence = GetNthFibonacci(100);
        }

        private List<BigInteger> GetNthFibonacci(int n) 
        { 

            for (int i = 2; i <= n; i++)
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
        public void Algorithm(int len, List<BigInteger> _seq)
        {
            _seq = LenghtFib(len).ToList();
            foreach (var item in _seq)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("ConcreteStrategy3");
        }

        public void Algorithm(int min, int max, List<BigInteger> _seq)
        {
            _seq = RangeFib(min, max).ToList();
            foreach (var item in _seq)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("ConcreteStrategy3");
        }
    }
}
