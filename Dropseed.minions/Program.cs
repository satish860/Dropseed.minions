using Dropseed.minions.Api;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Dropseed.minions
{
    class Program
    {
        static void Main(string[] args)
        {
           
            HostFactory.Run(x =>
                {
                    x.Service<Service>(p =>
                    {
                        p.ConstructUsing(name => new Service("http://localhost:8172"));
                        p.WhenStarted(tc => tc.Start());
                        p.WhenStopped(tc => tc.Stop());
                    });
                    x.RunAsLocalSystem();
                    x.SetDescription("Evolving from single-celled yellow organisms at the dawn of time, Minions live to serve");
                    x.SetDisplayName("Dropseed.minions");
                    x.SetServiceName("Dropseed.minions");
                });
        }
    }
}
