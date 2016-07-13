using Dropseed.minions.Api;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropseed.minions
{
    public class Service
    {
        IDisposable webServer;
        string baseAddress = "http://localhost:8172/";

        public void Start()
        {
            this.webServer = WebApp.Start<StartUp>(url: baseAddress);
        }

        public void Stop()
        {
            this.webServer.Dispose();
        }
    }
}
