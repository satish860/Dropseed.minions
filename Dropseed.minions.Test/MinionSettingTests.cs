using Dropseed.minions.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Should;

namespace Dropseed.minions.Test
{
    public class MinionSettingTests
    {
        public void ShouldBeAbleToFecthTheUrlFromSettings()
        {
            MinionSettings settings = new MinionSettings();
            settings.GetUrl("8172").ShouldEqual("http://localhost:8172");
        }
    }
}
