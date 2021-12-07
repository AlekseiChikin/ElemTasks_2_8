using NUnit.Framework;
using Task_3;

namespace Test_Task_3
{
    public class Tests
    {
        Triangle triangle;
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void AreaOfTriangle()
        {
            triangle = Triangle.Factory.Create("test", 3, 4, 5);

            var result = triangle.Area;

            Assert.AreEqual(6, result);
        }
    }
}