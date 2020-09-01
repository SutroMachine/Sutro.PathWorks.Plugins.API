using Sutro.Core.Models.Profiles;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface ISettingsManager
    {
        IPrintProfile CreateSettingsInstance();

        IProfileManager<IMachineProfile> MachineProfileManager { get; }

        IProfileManager<IMaterialProfile> MaterialProfileManager { get; }

        IProfileManager<IPartProfile> PartProfileManager { get; }
    }
}