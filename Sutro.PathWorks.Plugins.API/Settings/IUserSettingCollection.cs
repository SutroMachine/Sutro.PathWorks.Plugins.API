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
        IEnumerable<UserSettingBase> Settings();

        List<ValidationResult> Validate(object rawSettings);

        void LoadFromRaw(object rawSettings,
                         IEnumerable<UserSettingBase> userSettings);

        void ApplyToRaw(object rawSettings,
                        IEnumerable<UserSettingBase> userSettings);

        void SetCulture(CultureInfo cultureInfo);
    }

    public interface IUserSettingCollection<TSettings> : IUserSettingCollection
    {
        new IEnumerable<UserSettingBase<TSettings>> Settings();

        List<ValidationResult> Validate(TSettings rawSettings);

        void LoadFromRaw(TSettings rawSettings,
                         IEnumerable<UserSettingBase<TSettings>> userSettings);

        void ApplyToRaw(TSettings rawSettings,
                        IEnumerable<UserSettingBase<TSettings>> userSettings);
    }
}