using System;

namespace Sutro.PathWorks.Plugins.API.Settings
{
    /// <summary>
    /// Details on a numeric user setting
    /// </summary>
    /// <typeparam name="T">Should be numeric type (double, float or int)</typeparam>
    public abstract class NumericInfoBase<T> where T : IComparable
    {
        /// <summary>
        /// Optional minimum bound for user setting control
        /// </summary>
        public NumericBound<T> Minimum { get; set; }

        /// <summary>
        /// Optional maximum bound for user setting control
        /// </summary>
        public NumericBound<T> Maximum { get; set; }

        /// <summary>
        /// Amount to increment when using spinbox user setting control
        /// </summary>
        public abstract T Increment { get; set; }
    }
}