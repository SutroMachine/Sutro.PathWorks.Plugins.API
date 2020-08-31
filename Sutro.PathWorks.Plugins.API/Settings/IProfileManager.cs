using Sutro.Core.Models;
using Sutro.Core.Models.Profiles;
using System.Collections.Generic;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface IProfileManager<TSettings, TProfile> where TProfile : IProfile<TSettings>
    {
        List<IProfile<TSettings>> FactoryProfiles { get; }

        void ApplyJSON(IProfile<TSettings> settings, string json);
        void ApplyKeyValuePair(IProfile<TSettings> settings, string keyValue);

        IProfile<TSettings> DeserializeJSON(string json);
        string SerializeJSON(IProfile<TSettings> settings);

        IUserSettingCollection<TProfile> UserSettings { get; }
    }
}