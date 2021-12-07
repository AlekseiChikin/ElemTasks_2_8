using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Task_8
{
    public class ConcreteStrategy2 : IStrategy
    {
        public void Algorithm(int x, List<BigInteger> _sequence)
        {

            int len = x;
            int begin = (int)Math.Pow(10, (len - 1));
            if (begin == 1) { begin--; }
            int end = (int)Math.Pow(10, len);

            Algorithm(begin, end, _sequence);
        }

        public void Algorithm(int begin, int end, List<BigInteger> _sequence)
        {
  
            int j = 0;
            for (int i = 1; i <= end; i += j)
            {
                if (i >= begin)
                {
                    _sequence.Add(i);
                }
                j = i - j;
            }
            foreach (var item in _sequence)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("ConcreteStrategy2");

        }
    }
}
