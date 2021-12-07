using System.Collections.Generic;
using System.Numerics;

namespace Task_8
{
    public interface IStrategy
    {
        void Algorithm(int len, List<BigInteger> _sequence);
        void Algorithm(int min, int max, List<BigInteger> _sequence);
    }
}
