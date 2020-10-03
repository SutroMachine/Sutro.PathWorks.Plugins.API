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

        void ApplyToRaw(object settings);

        void LoadFromRaw(object settings);
    }
}