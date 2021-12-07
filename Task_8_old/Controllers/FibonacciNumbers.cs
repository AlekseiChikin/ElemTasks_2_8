using System.Collections.Generic;
using System.Numerics;
using Task_8_.Controllers;

namespace Task_8_old
{
    public class FibonacciNumbers : Sequence<BigInteger>
    {
        public List<BigInteger> sequence;
        const int DEFAULT_NUMBER_OF_ELEMENTS = 10_000;
        public FibonacciNumbers(int numberOfElements = DEFAULT_NUMBER_OF_ELEMENTS)
        {
            sequence = new List<BigInteger>() { 0, 1 };

            GenerateSequence(numberOfElements);
        }
        private void GenerateSequence(int sequenceLenght)
        {
            int lastIndexOfElemInSequence = sequence.Count;

            for (int i = lastIndexOfElemInSequence; i < sequenceLenght; i++)
            {
                sequence.Add(sequence[i - 2] + sequence[i - 1]);
            }  
        }
        public override IEnumerable<BigInteger> GetSequence()
        {
            return sequence;
        }
    }  
}