using System.ServiceModel.Web;
using Moq;
using NUnit.Framework;
using SampleWCF;

namespace SampleWCFNTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test()
        {
            var service=new HelloWorldService();
            var mockService = new Mock<IWebOperationContext> {DefaultValue = DefaultValue.Mock};
            using (new MockedWebOperationContext(mockService.Object))
            {
                service.SayHello("asdad");
            }

        }
    }
}
