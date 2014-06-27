using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Archiver
{
    class clsTools
    {
        public string PublishVersion
        {
            get
            {
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    return string.Format("{0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision);
                }
                else
                    return "Not Published";
            }
        }
    }
}
