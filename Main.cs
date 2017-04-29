using System;
using System.Linq;
using System.Reflection;
using Rocket.API;
using Rocket.Unturned.Player;
using UnityEngine;
using SDG.Unturned;
using Rocket.Core.Plugins;
using Rocket.Core.Logging;
using Rocket.API.Collections;
using Rocket.Unturned.Chat;
using Rocket.Core;
using System.Collections.Generic;

namespace coolpuppy24.staffhelp
{
    public class Main : RocketPlugin<Configuration>
    {
        public static Main Instance = null;


        protected override void Load()
        {
            Instance = this;

            Rocket.Core.Logging.Logger.LogWarning("[StaffHelp] Made by: Coolpuppy24");
            Rocket.Core.Logging.Logger.LogWarning("[StaffHelp] Chat Color: " + Configuration.Instance.ChatColorName);
            Rocket.Core.Logging.Logger.LogWarning("[StaffHelp] Successfully Loaded StaffHelp!");
        }

        protected override void Unload()
        {
            Rocket.Core.Logging.Logger.Log("Unload");
        }
    }
}
