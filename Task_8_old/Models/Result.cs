using System.Collections.Generic;
using System.Numerics;

namespace Task_8_old
{
    class Result
    {
        public Dictionary<int, IEnumerable<BigInteger>> Lenght { get; set; }
        public Dictionary<(int, int), IEnumerable<BigInteger>> Range { get; set; }

        public Result()
        {
            Lenght = new Dictionary<int, IEnumerable<BigInteger>>();
            Range = new Dictionary<(int, int), IEnumerable<BigInteger>>();
        }

    }
}
