﻿using Sutro.Core.Models;
using Sutro.Core.Models.Profiles;
using System.Collections.Generic;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface ISettingsManager
    {
        List<IProfile> FactorySettings { get; }

        IProfile FactorySettingByManufacturerAndModel(string manufacturer, string model);

        void ApplyJSON(IProfile settings, string json);

        IProfile DeserializeJSON(string json);

        string SerializeJSON(IProfile settings);

        void ApplyKeyValuePair(IProfile settings, string keyValue);

        IUserSettingCollection MachineUserSettings { get; }
        IUserSettingCollection MaterialUserSettings { get; }
        IUserSettingCollection PrintUserSettings { get; }
    }

    public interface ISettingsManager<TSettings> : ISettingsManager where TSettings : IMachineProfile, IMaterialProfile, IPartProfile
    {
        new List<TSettings> FactorySettings { get; }

        new TSettings FactorySettingByManufacturerAndModel(string manufacturer, string model);

        void ApplyJSON(TSettings settings, string json);

        new TSettings DeserializeJSON(string json);

        string SerializeJSON(TSettings settings);

        void ApplyKeyValuePair(TSettings settings, string keyValue);

        new IUserSettingCollection<TSettings> MachineUserSettings { get; }

        new IUserSettingCollection<TSettings> MaterialUserSettings { get; }

        new IUserSettingCollection<TSettings> PrintUserSettings { get; }
    }
}