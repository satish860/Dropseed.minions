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
        public IList<string> Get()
        {
            using (PowerShell powershellInstance = PowerShell.Create())
            {
                powershellInstance.AddScript(@"Import-Module WebAdministration;Set-Location IIS:\;");
                var instanceResult = powershellInstance.Invoke();
                powershellInstance.AddScript("Dir");
                var directoryResult = powershellInstance.Invoke();

            }
            return null;
        }
    }
}
