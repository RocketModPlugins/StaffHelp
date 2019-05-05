using System.Threading.Tasks;
using Rocket.API.DependencyInjection;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;

namespace StaffHelp
{
    public class StaffHelpPlugin : Plugin
    {
        public StaffHelpPlugin(IDependencyContainer container) : base("StaffHelp", container)
        {
            
        }

        protected override async Task OnActivate(bool isFromReload)
        {
            Logger.LogInformation("[Staff Chat] Activated successfully.");
        }

        protected override async Task OnDeactivate()
        {
            Logger.LogInformation("[Staff Chat] Shutting down.");
        }
    }
}
