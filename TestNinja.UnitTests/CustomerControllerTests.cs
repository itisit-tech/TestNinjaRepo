using NUnit.Framework;
using NUnit.Framework.Constraints;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);
            //Not found
            Assert.That(result, Is.TypeOf<NotFound>());
            
            //Not found or one of its derivatives
            //Assert.That(result,Is.InstanceOf<NotFound>());
        }
        [Test]
        public void GetCustomer_IdIsOne_ReturnOk()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(1);
            //Not found
            Assert.That(result, Is.TypeOf<Ok>());
            
            //Not found or one of its derivatives
            //Assert.That(result,Is.InstanceOf<NotFound>());
        }
    }
}