using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coolpuppy24.staffhelp
{

    public class Configuration : IRocketPluginConfiguration
    {
        public string ChatColorName;

        public void LoadDefaults()
        {
            ChatColorName = "Blue";
        }
    }
}
