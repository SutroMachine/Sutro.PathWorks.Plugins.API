using System.Collections.ObjectModel;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface IUserSettingString : IUserSettingGeneric<string>
    {
        ReadOnlyCollection<UserSettingEnumOption> Options { get; }

        ValidationResult Validate();
    }
}