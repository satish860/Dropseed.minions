using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropseed.minions.Api
{
    public class MinionSettings
    {
        public string GetUrl(string port)
        {
            return string.Format("http://localhost:{0}", port);
        }
    }
}
