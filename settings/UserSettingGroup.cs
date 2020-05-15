using System;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public class UserSettingGroup
    {
        private readonly Func<string> NameF;

        public string Name => NameF();

        public UserSettingGroup(Func<string> nameF, Func<string> descriptionF = null)
        {
            NameF = nameF;
        }


    }
}
