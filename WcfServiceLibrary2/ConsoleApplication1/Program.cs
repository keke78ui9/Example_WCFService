using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Net;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleCall.Service1Client data = new ConsoleCall.Service1Client();
            data.Endpoint.Address =
                new EndpointAddress("http://localhost:8732/Design_Time_Addresses/WcfServiceLibrary1/Service1/");
            data.ClientCredentials.Windows.ClientCredential =
                CredentialCache.DefaultNetworkCredentials;

            Console.WriteLine(data.GetData(10));
            Console.ReadLine();


            Console.WriteLine(Class1.GetThis());
            Console.ReadLine();
            
        }
    }
}
