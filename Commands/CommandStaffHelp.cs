using System;
using System.Collections.Generic;
using System.Drawing;
using Rocket.API.Commands;
using Rocket.API.Permissions;
using Rocket.API.User;
using Rocket.Core.User;

namespace StaffHelp.Commands
{
    public class CommandStaffHelp : ICommand
    {
        public string Name => "StaffHelp";
        public string[] Aliases => new[] {"sh"};
        public string Summary => "Sends message to staff.";
        public string Description => null;
        public string Permission => null;
        public string Syntax => "<message>";
        public IChildCommand[] ChildCommands => null;

        public bool SupportsUser(Type user)
        {
            return true;
        }

        public void Execute(ICommandContext context)
        {
            var userManager = context.Container.Resolve<IUserManager>();
            var permissionManager = context.Container.Resolve<IPermissionProvider>();

            string message = string.Join(" ", context.Parameters.ToArray());

            List<IUser> receivers = new List<IUser>();
            foreach (var user in userManager.Users)
            {
                if(permissionManager.CheckPermission(user, "staffhelp.receive") != PermissionResult.Grant)
                    continue;
                receivers.Add(user);
            }

            userManager.Broadcast(context.User, receivers, $"[StaffHelp] {context.User.Name}: {message}", Color.Red);
        }
    }
}