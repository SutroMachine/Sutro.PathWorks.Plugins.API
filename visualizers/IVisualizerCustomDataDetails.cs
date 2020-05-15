namespace Sutro.PathWorks.Plugins.API
{
    public interface IVisualizerCustomDataDetails
    {
        string Label { get; }
        float RangeMin { get; }
        float RangeMax { get; }

        string FormatColorScaleLabel(float value);
    }
}