using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using WCFMock.SampleService;

namespace WCFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/");
            var binding = new WebHttpBinding();
            
           
            // Create the ServiceHost.
            using (WebServiceHost host = new WebServiceHost(typeof(ProductCatalog), baseAddress))
            {
                host.AddServiceEndpoint(typeof(IProductCatalog), binding, baseAddress.AbsoluteUri);
                ServiceDebugBehavior stp = host.Description.Behaviors.Find<ServiceDebugBehavior>();
                stp.HttpHelpPageEnabled = true;

                // Enable metadata publishing.
                //ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                //smb.HttpGetEnabled = true;
                //smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                //host.Description.Behaviors.Add(smb);

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();

                Console.WriteLine("The service is ready at {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}
