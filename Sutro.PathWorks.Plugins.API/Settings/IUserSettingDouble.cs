namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface IUserSettingDouble : IUserSettingGeneric<double>
    {
        NumericInfoDouble NumericInfo { get; }

        /// <summary>
        /// If true, the numeric value should be multiplied by 100 to convert to a percentage for display
        /// </summary>
        bool ConvertToPercentage { get; }
    }
}