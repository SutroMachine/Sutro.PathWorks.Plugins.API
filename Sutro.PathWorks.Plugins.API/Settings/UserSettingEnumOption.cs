using System;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public class UserSettingEnumOption
    {
        public int EnumInt { get; }

        public string EnumString { get; }

        public Func<string> Label { get; }

        public UserSettingEnumOption(int enumInt, string enumString, Func<string> label)
        {
            EnumInt = enumInt;
            EnumString = enumString;
            Label = label;
        }
    }
}