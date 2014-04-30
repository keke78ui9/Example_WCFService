using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            WindowsCall.Service1Client data = new WindowsCall.Service1Client();
            data.Endpoint.Address =
                new EndpointAddress("http://localhost:8732/Design_Time_Addresses/WcfServiceLibrary1/Service1/");
            data.ClientCredentials.Windows.ClientCredential =
                CredentialCache.DefaultNetworkCredentials;

            this.Text = data.GetData(10);
        }
    }
}
