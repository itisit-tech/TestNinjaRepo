using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEnclosedStringWithBolTags()
        {
            var formatter = new HtmlFormatter();
            
            var result = formatter.FormatAsBold("Hello");
            Assert.AreEqual("<strong>Hello</strong>", result);
        }
    }
}