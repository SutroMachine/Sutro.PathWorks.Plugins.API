using System;

namespace Sutro.PathWorks.Plugins.API
{
    public class UserSettingBool<TSettings> : UserSetting<TSettings, bool>
    {
        public UserSettingBool(
            string id,
            Func<string> nameF,
            Func<string> descriptionF,
            UserSettingGroup group,
            Func<TSettings, bool> loadF,
            Action<TSettings, bool> applyF,
            Func<bool, ValidationResult> validateF = null) : base(id, nameF, descriptionF, group, loadF, applyF, validateF)
        {
        }
    }
}