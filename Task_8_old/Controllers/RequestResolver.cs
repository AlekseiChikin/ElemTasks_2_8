using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Task_8_.Controllers
{
    public class RequestResolver
    {
        private IEnumerable<BigInteger> sequence;

        public RequestResolver(Sequence<BigInteger> sequence)
        {
            this.sequence = sequence.GetSequence();
        }
        public IEnumerable<BigInteger> Result((int first, int last) range)
        {

            bool resultShouldBeReversed = IsSwaped(ref range.first, ref range.last);
            int firstInRange = range.first;
            int lastInRange = range.last;

            IEnumerable<BigInteger> requiredInterval;

            if (firstInRange < 0 && lastInRange >= 0)
            {
                int signCheck = 1;
                requiredInterval = sequence
                    .Where(x => x > 0 && x <= Math.Abs(firstInRange))
                    .Select(x => signCheck++ % 2 == 0 ? -x : x)
                    .Reverse()
                    .Concat(sequence.Where(x => x >= 0 && x <= lastInRange));
            }
            else if (firstInRange >= 0 && lastInRange > 0)
            {
                requiredInterval = sequence.Where(x => x >= firstInRange && x <= lastInRange);
            }
            else
            {
                requiredInterval = sequence.Where(x => x >= Math.Abs(firstInRange) && x <= Math.Abs(lastInRange))
                    .Select(x => -x);
            }
            return resultShouldBeReversed ?  requiredInterval.Reverse() : requiredInterval;
        }
        bool IsSwaped(ref int first, ref int second)
        {
            bool result = second < first;
            int temp;
            if (result)
            {
                temp = first;
                first = second;
                second = temp;
            }
            return result;
        }
        public IEnumerable<BigInteger> Result(int lenght)
        {
            IEnumerable<BigInteger> requiredNumberLenght;
            if (lenght < 0)
            {
                lenght = Math.Abs(lenght);
                double signCheck = GetIndexFromElem(Math.Pow(10, lenght));
                requiredNumberLenght = sequence.Where(x => x.ToString().Length == lenght)
                    .Select(x => signCheck++ % 2 == 0 ? -x : x)
                    .Reverse();
            }
            else
            {
                requiredNumberLenght = sequence.Where(x => x.ToString().Length == lenght);
            }
            return requiredNumberLenght;
        }

        private double GetIndexFromElem(double elem)
        {
            double goldenRatio = (Math.Sqrt(5) + 1) / 2;
            return Math.Floor(Math.Log10(elem * Math.Sqrt(5) + 0.5) / Math.Log10(goldenRatio));
        }
  
    }
}
