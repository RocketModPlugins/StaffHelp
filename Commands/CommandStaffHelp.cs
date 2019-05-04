using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
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

        public bool SupportsUser(IUser user) => true;

        public async Task ExecuteAsync(ICommandContext context)
        {
            var userManager = context.Container.Resolve<IUserManager>();
            var permissionManager = context.Container.Resolve<IPermissionProvider>();
            var permissionChecker = context.Container.Resolve<IPermissionChecker>;

            string message = string.Join(" ", context.Parameters.ToArray());

            List<IUser> receivers = new List<IUser>();
            foreach (var user in userManager.)
            {
                if(permissionChecker.CheckPermission(user, "staffhelp.receive") != PermissionResult.Grant)
                    continue;
                receivers.Add(user);
            }

            await userManager.BroadcastAsync(context.User, receivers, $"[StaffHelp] {context.User.UserName}: {message}", Color.Red);
        }
    }
}