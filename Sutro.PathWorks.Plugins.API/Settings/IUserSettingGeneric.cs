namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface IUserSettingGeneric<T> : IUserSetting
    {
        T Value { get; set; }

        T GetFromRaw(object settings);

        void SetToRaw(object settings, T value);
    }
}