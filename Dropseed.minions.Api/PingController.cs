using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Dropseed.minions.Api
{
    public class PingController:ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("I am availble and ready to execute some powerful things!!");
        }
    }
}
