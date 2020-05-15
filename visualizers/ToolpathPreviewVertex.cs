using g3;
using System;

namespace Sutro.PathWorks.Plugins.API.Visualizers
{
    public readonly struct ToolpathPreviewVertex
    {
        public CustomColorData CustomColorData { get; }
        public Vector3d Point { get; }
        public Vector3f Color { get; }
        public int FillType { get; }
        public int LayerIndex { get; }
        public float Brightness { get; }

        public ToolpathPreviewVertex(Vector3d point, int fillType, int layerIndex, Vector3f color, float brightness, CustomColorData colorData)
        {
            Point = point;
            FillType = fillType;
            LayerIndex = layerIndex;
            Color = color;
            Brightness = brightness;
            CustomColorData = colorData;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ToolpathPreviewVertex o))
                return false;

            return
                CustomColorData.Equals(o.CustomColorData) &&
                Point.Equals(o.Point) &&
                Color.Equals(o.Color) &&
                FillType.Equals(o.FillType) &&
                LayerIndex.Equals(o.LayerIndex) &&
                Brightness.Equals(o.Brightness);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CustomColorData, Point, Color, FillType, LayerIndex, Brightness);
        }
    }
}