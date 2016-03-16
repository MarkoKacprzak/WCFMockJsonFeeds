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
            HelloWorldService service=new HelloWorldService();
            Mock<IWebOperationContext> mockService = new Mock<IWebOperationContext> {DefaultValue = DefaultValue.Mock};
            using (new MockedWebOperationContext(mockService.Object))
            {
                service.SayHello("asdad");
            }

        }
    }
}
