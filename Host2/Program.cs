using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;

namespace host
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Uri baseAddress = new Uri(
                "http://localhost:8735/Conversor");
            ServiceHost selfHost = new ServiceHost(
                typeof(MulticonversorSistemasNumericos.Service1), baseAddress);

            WSHttpBinding binding = new WSHttpBinding();
            selfHost.AddServiceEndpoint(typeof(
                MulticonversorSistemasNumericos.IService1), binding, "Conversor");

            ServiceMetadataBehavior smb =
                new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(smb);

            selfHost.Open();
            Console.WriteLine("The service is ready.");
            Console.WriteLine("Press <ENTER> to terminate service.");
            Console.WriteLine();
            Console.ReadLine();
            selfHost.Close();

        }
    }
}