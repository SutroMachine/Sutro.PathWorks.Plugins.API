namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface IUserSettingDoubleListVariableLength : IUserSettingDoubleList
    {
        int MinimumCount { get; }

        int MaximumCount { get; }
    }
}