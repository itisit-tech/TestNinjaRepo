using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_SumOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result,Is.EqualTo(3));
        }

        [Test]
        [TestCase(1,2,2)]
        [TestCase(2,1,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnTheGreatestArgument(int a, int b, int expected)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
        
        [Test]
        [Ignore("Because added parameter test")]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
        {
            var result = _math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
            
        }
        [Test]
        [Ignore("Because added parameter test")]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {
           
            var result = _math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        [Ignore("Because added parameter test")]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            var result = _math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}