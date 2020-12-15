using System.Collections.Generic;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    public interface IUserSettingDoubleList : IUserSettingGeneric<List<double>>
    {
        NumericInfoDouble NumericInfo { get; }

        int DecimalDigits { get; }

        /// <summary>
        /// If true, the numeric value should be multiplied by 100 to convert to a percentage for display
        /// </summary>
        bool ConvertToPercentage { get; }

        ValidationResult Validate();
    }
}