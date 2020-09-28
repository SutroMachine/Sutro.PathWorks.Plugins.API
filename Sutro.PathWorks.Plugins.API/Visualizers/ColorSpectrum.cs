using System.Drawing;

namespace Sutro.PathWorks.Plugins.API.Visualizers
{
    public class ColorSpectrum
    {
        public Color[] Colors { get; } = new Color[11];

        /// <summary>
        /// Create a new ColorSpectrum.
        /// </summary>
        /// <remarks>
        /// This constructor has a long argument list to avoid creating
        /// or passing a collection with a length other than 11.
        /// </remarks>
        public ColorSpectrum(
            Color color0, Color color1, Color color2, Color color3,
            Color color4, Color color5, Color color6, Color color7,
            Color color8, Color color9, Color color10)
        {
            Colors[0] = color0;
            Colors[1] = color1;
            Colors[2] = color2;
            Colors[3] = color3;
            Colors[4] = color4;
            Colors[5] = color5;
            Colors[6] = color6;
            Colors[7] = color7;
            Colors[8] = color8;
            Colors[9] = color9;
            Colors[10] = color10;
        }
    }
}