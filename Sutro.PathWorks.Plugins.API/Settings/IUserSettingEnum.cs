using System.Collections.ObjectModel;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface IUserSettingEnum : IUserSettingGeneric<int>
    {
        ReadOnlyCollection<UserSettingEnumOption> Options { get; }
    }
}