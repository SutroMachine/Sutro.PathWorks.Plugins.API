using g3;
using System;

namespace Sutro.PathWorks.Plugins.API.Visualizers
{
    public readonly struct VisualizerFillType
    {
        public string Label { get; }

        public Vector3f Color { get; }

        public VisualizerFillType(string label, Vector3f color)
        {
            Label = label;
            Color = color;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is VisualizerFillType o))
                return false;

            return
                Label.Equals(o.Label) &&
                Color.Equals(o.Color);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Label, Color);
        }
    }
}