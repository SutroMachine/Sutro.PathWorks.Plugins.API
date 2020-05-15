using g3;

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
    }
}