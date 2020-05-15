using System;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public class UserSettingGroup
    {
        private readonly Func<string> nameF;

        public string Name => nameF();

        public UserSettingGroup(Func<string> nameF, Func<string> descriptionF = null)
        {
            this.nameF = nameF;
        }


    }
}
