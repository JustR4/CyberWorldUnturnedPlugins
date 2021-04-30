using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberWorldPlugins
{
    public class Config : IRocketPluginConfiguration
    {
        public bool CyberWorldAdminTools;



        public void LoadDefaults()
        {
            CyberWorldAdminTools = false;

        }
    }
}
