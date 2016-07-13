using Dropseed.minions.Api;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropseed.minions
{
    public class Service
    {
        IDisposable webServer;
        string baseAddress;
        private readonly MinionSettings settings;

        public Service()
        {
            settings = new MinionSettings();
            fetchSettings();
           
        }

        private void fetchSettings()
        {
            string jsondata = File.ReadAllText("settings.json");
            dynamic settingjson=Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(jsondata);
            baseAddress=settings.GetUrl(settingjson.Port.Value);
        }

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
