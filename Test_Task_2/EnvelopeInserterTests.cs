using NUnit.Framework;
using Task_2.Models;
using Task_2.Controllers;

namespace Test_Task_2
{
    public class EnvelopeInserterTests
    {
        private Envelope h10w10;
        private Envelope h11w1;

        private EnvelopeInserter<BasicStrategy> inserterBasicStrategy;
        private EnvelopeInserter<GeometryStrategy> inserterGeometryStrategy;
        private EnvelopeInserter<TrigonometryStrategy> inserterTrigonometryStrategy;
        [SetUp]
        public void Setup()
        {
            h10w10 = new Envelope(10, 10);
            h11w1 = new Envelope(11, 1);

        }

        [Test]
        public void GeometryInserterDiagonalCase()
        {
            var inserterGeometryStrategy = new EnvelopeInserter<GeometryStrategy>(h10w10, h11w1);

            var result = inserterGeometryStrategy.Insertable();

            Assert.IsTrue(result);
        }
        [Test]
        public void BasicInserterDiagonalCase()
        {
            var inserterGeometryStrategy = new EnvelopeInserter<BasicStrategy>(h10w10, h11w1);

            var result = inserterGeometryStrategy.Insertable();

            Assert.IsFalse(result);
        }
    }
}