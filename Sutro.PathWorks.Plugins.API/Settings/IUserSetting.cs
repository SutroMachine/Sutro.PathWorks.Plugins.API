﻿using Sutro.Core.Models.Profiles;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface IUserSetting
    {
        string Name { get; }
        string Id { get; }
        string Description { get; }
        string Units { get; }
        bool Hidden { get; }
        IUserSettingGroup Group { get; }

        void ApplyToRaw<T>(T profile) where T : IProfile;

        void LoadFromRaw<T>(T profile) where T : IProfile;

        void LoadAndApply<T>(T targetProfile, T sourceProfile) where T : IProfile;
    }
}