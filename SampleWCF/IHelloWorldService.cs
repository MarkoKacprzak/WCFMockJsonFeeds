using System.ServiceModel;

namespace SampleWCF
{
    [ServiceContract]
    public interface IHelloWorldService
    {
        [OperationContract]
        string SayHello(string name);
    }
}