using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;

namespace Dropseed.minions.Api.Query
{
    public class GetAppPools
    {
        public IEnumerable<string> Get()
        {
            using (PowerShell powershellInstance = PowerShell.Create())
            {
                powershellInstance.AddScript("set-executionpolicy Unrestricted");
                var policy = powershellInstance.Invoke();
                powershellInstance.AddScript(@"Import-Module WebAdministration");
                powershellInstance.AddScript(@"Set-Location IIS:\");
                powershellInstance.AddScript("Get-ChildItem AppPools");
                var instanceResult = powershellInstance.Invoke();
                if (powershellInstance.Streams.Error.Count == 0)
                {
                    var AppPoolNames = instanceResult.Select(p => p.Properties["Name"]);
                    return AppPoolNames.Select(p=>p.Value.ToString());
                }

            }
            return null;
        }
    }
}
