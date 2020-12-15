namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface IUserSettingDoubleListFixedLength : IUserSettingDoubleList
    {
        int Count { get; }
    }
}