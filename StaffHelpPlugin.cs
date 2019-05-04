using Rocket.API.DependencyInjection;
using Rocket.Core.Plugins;

namespace StaffHelp
{
    public class StaffHelpPlugin : Plugin
    {
        public StaffHelpPlugin(IDependencyContainer container) : base("StaffHelp", container)
        {
            
        }
    }
}
