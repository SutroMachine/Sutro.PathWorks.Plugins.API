using Sutro.Core.Models.Profiles;
using System.Collections.Generic;
using System.Globalization;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    /// <summary>
    /// Provides a common interface to raw settings.
    /// </summary>
    /// <remarks>
    /// The common version of this interface is provided so that calling code
    /// doesn't need to know about the type of the underlying raw setting.
    /// However, concrete classes should not use this interface directly;
    /// rather, they should implement the typed version IUserSettingCollection<TSettings>
    /// to enforce matching types for the raw settings object.
    /// </remarks>
    public interface IUserSettingCollection
    {
        IEnumerable<IUserSetting> Settings();

        List<ValidationResult> Validate(object rawSettings);

        void LoadFromRaw(object rawSettings,
                         IEnumerable<IUserSetting> userSettings);

        void ApplyToRaw(object rawSettings,
                        IEnumerable<IUserSetting> userSettings);

        void SetCulture(CultureInfo cultureInfo);
    }
}