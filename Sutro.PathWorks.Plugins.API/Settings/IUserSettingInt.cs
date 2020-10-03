namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface IUserSettingInt : IUserSettingGeneric<int>
    {
        NumericInfoInt NumericInfo { get; }
    }
}