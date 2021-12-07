using System.Collections.Generic;
using System.Numerics;

namespace Task_8
{

    class FibonacciNumbers
    {
        private List<BigInteger> _sequence;
        private IStrategy _contextStrategy;

        public FibonacciNumbers(IStrategy _strategy)
        {
            _contextStrategy = _strategy;
            _sequence = new List<BigInteger>() { 0, 1 };
        }
    
        public void ExecuteAlgorithm(int len)//GetResult
        {
            _contextStrategy.Algorithm(len, _sequence);
        }
        public void ExecuteAlgorithm(int min, int max)//GetResult
        {
            _contextStrategy.Algorithm(min, max , _sequence);
        }

    }
}
