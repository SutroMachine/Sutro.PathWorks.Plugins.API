using Sutro.Core.Models;
using Sutro.Core.Models.Profiles;
using System.Collections.Generic;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface IProfileManager<TProfile> where TProfile : IProfile
    {
        List<TProfile> FactoryProfiles { get; }

        void ApplyJSON(TProfile settings, string json);
        void ApplyKeyValuePair(TProfile settings, string keyValue);

        TProfile DeserializeJSON(string json);
        string SerializeJSON(TProfile settings);

        IUserSettingCollection<TProfile> UserSettings { get; }
    }
}