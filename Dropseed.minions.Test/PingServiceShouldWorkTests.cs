using Dropseed.minions.Api;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Should;

namespace Dropseed.minions.Test
{
    public class PingServiceShouldWorkTests
    {
        public async Task ShouldBeAbleToPingTheServiceOnceInstalled()
        {
            using (WebApp.Start<StartUp>(url: "http://localhost:9000"))
            {
                HttpClient client = new HttpClient();
                var response = await client.GetAsync("http://localhost:9000/api/ping");
                response.IsSuccessStatusCode.ShouldBeTrue();

            }
        }
    }
}
