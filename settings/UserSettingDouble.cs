﻿using System;

namespace Sutro.PathWorks.Plugins.API
{
    public class UserSettingDouble<TSettings> : UserSetting<TSettings, double>
    {
        public UserSettingDouble(
            string id,
            Func<string> nameF,
            Func<string> descriptionF,
            UserSettingGroup group,
            Func<TSettings, double> loadF,
            Action<TSettings, double> applyF,
            Func<double, ValidationResult> validateF = null) : base(id, nameF, descriptionF, group, loadF, applyF, validateF)
        {
        }
    }
}