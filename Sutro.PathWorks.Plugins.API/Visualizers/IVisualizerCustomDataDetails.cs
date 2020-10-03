namespace Sutro.PathWorks.Plugins.API.Visualizers
{
    public interface IVisualizerCustomDataDetails
    {
        string Label { get; }
        float RangeMin { get; }
        float RangeMax { get; }

        string FormatColorScaleLabel(float value);

        ColorSpectrum GetSpectrum() => null;
    }
}