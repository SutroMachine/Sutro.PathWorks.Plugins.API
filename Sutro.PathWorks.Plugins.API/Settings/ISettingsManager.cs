using Sutro.Core.Models.Profiles;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface ISettingsManager
    {
        object CreateSettingsInstance();

        IProfileManager<object, IMachineProfile<object>> MachineProfileManager { get; }

        IProfileManager<object, IProfile<object>> MaterialProfileManager { get; }

        IProfileManager<object, IProfile<object>> PartProfileManager { get; }
    }

    public interface ISettingsManager<TSettings> : ISettingsManager
    {
        new TSettings CreateSettingsInstance();

        new IProfileManager<TSettings, IMachineProfile<TSettings>> MachineProfileManager { get; }

        new IProfileManager<TSettings, IProfile<TSettings>> MaterialProfileManager { get; }

        new IProfileManager<TSettings, IProfile<TSettings>> PartProfileManager { get; }
    }
}