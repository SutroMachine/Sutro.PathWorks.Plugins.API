using Sutro.Core.Models.Profiles;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface ISettingsManager
    {
        IPrintProfile CreateSettingsInstance();

        IMachineProfileManager MachineProfileManager { get; }

        IMaterialProfileManager MaterialProfileManager { get; }

        IPartProfileManager PartProfileManager { get; }
    }
}