﻿namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface IUserSettingString : IUserSettingGeneric<string>
    {
        ValidationResult Validate();
    }
}