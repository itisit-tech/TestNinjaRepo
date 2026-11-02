using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedLessThan0OrGreaterThan300_ThrowsException(int speed)
        {
            var demeritCalculator = new DemeritPointsCalculator();
            Assert.That(()=>demeritCalculator.CalculateDemeritPoints(speed),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        
        [Test]
        [TestCase(0,0)]
        [TestCase(35,0)]
        [TestCase(65,0)]
        [TestCase(67,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed,int expectedPoints)
        {
            var demeritCalculator = new DemeritPointsCalculator();
            var points = demeritCalculator.CalculateDemeritPoints(speed);
            Assert.That(points, Is.EqualTo(expectedPoints));
        }
        
    }
}