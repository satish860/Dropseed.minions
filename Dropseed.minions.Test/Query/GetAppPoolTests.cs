using Dropseed.minions.Api.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropseed.minions.Test.Query
{
    public class GetAppPoolTests
    {
        public void ShouldBeAbleToGetAllTheAppPoolRegistered()
        {
            GetAppPools appPool = new GetAppPools();
            appPool.Get();
        }
    }
}
