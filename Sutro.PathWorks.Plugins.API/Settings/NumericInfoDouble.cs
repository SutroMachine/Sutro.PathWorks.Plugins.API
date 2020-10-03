namespace Sutro.PathWorks.Plugins.API.Settings
{
    public class NumericInfoDouble : NumericInfoBase<double>
    {
        public override double Increment { get; set; } = 0.05;
    }
}