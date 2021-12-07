using NUnit.Framework;
using System.Collections.Generic;
using Task_8_.Controllers;
using Task_8_old;
using System.Numerics;
using System.Linq;

namespace Test_Task_8
{
    public class RequestResolverTests
    {
        FibonacciNumbers sequence;
        [SetUp]
        public void Setup()
        {
            sequence = new FibonacciNumbers();
        }

        [Test]
        public void Test1()
        {

            // Arrange
            var requestResolver = new RequestResolver(sequence);
            IEnumerable<BigInteger> fa = new List<BigInteger> { 0, 1, 1, 2, 3, 5, 8 };
            IEnumerable<BigInteger> bigIntegers = fa;

            // Act
            var actual = requestResolver.Result(1);
            


            // Assert
            Assert.AreEqual(bigIntegers, actual);
        }
        [Test]
        public void Test2()
        {

            // Arrange
            var requestResolver = new RequestResolver(sequence);

            // Act
            var actual = requestResolver.Result((10,20));

            IEnumerable<BigInteger> fa = new List<BigInteger> { 13 };
            IEnumerable<BigInteger> bigIntegers = fa;

            // Assert
            Assert.AreEqual(bigIntegers, actual);
        }
    }
}