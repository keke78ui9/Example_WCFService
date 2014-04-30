using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Net;

namespace ClassLibrary1
{
    public class Class1
    {

        public static string GetThis()
        {
            LibraryCall.Service1Client data = new LibraryCall.Service1Client();
            data.Endpoint.Address =
                new EndpointAddress("http://localhost:8732/Design_Time_Addresses/WcfServiceLibrary1/Service1/");
            data.ClientCredentials.Windows.ClientCredential =
                CredentialCache.DefaultNetworkCredentials;
            return data.GetData(10);
        }
    }
}
