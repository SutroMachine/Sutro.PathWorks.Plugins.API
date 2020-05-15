using g3;

namespace Sutro.PathWorks.Plugins.API
{
    public struct VisualizerFillType
    {
        public string Label { get; }

        public Vector3f Color { get; }

        public VisualizerFillType(string label, Vector3f color)
        {
            Label = label;
            Color = color;
        }
    }
}