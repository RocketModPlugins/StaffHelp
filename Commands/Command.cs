using Rocket.API;
using Rocket.API.Extensions;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace coolpuppy24.staffhelp
{
    public class Command : IRocketCommand
    {
        public static Main Instance;

        public List<string> Aliases
        {
            get
            {
                return new List<string>() {"sh"};
            }
        }

        public AllowedCaller AllowedCaller
        {
            get
            {
                return AllowedCaller.Player;
            }
        }

        public string Help
        {
            get
            {
                return "";
            }
        }

        public string Name
        {
            get
            {
                return "staffhelp";
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>() { "staffhelp.send" };
            }
        }

        public string Syntax
        {
            get
            {
                return "<message>";
            }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;

            string message = command.GetParameterString(0);

            Provider.clients.ConvertAll(UnturnedPlayer.FromSteamPlayer).FindAll(x => x.HasPermission("staffhelp.receive")).ForEach(staffmems => UnturnedChat.Say(staffmems, $"[StaffHelp] {player.CharacterName}: {message}", UnturnedChat.GetColorFromName(Main.Instance.Configuration.Instance.ChatColorName, Color.red)));
        }
    }
}
