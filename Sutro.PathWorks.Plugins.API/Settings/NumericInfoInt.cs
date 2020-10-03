namespace Sutro.PathWorks.Plugins.API.Settings
{
    public class NumericInfoInt : NumericInfoBase<int>
    {
        public override int Increment { get; set; } = 1;
    }
}