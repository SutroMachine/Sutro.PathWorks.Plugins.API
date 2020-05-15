using g3;
using Sutro.Core.Models.GCode;
using System;
using System.Collections.Generic;

namespace Sutro.PathWorks.Plugins.API
{
    public interface IVisualizer
    {
        void BeginGCodeLineStream();

        void ProcessGCodeLine(GCodeLine line);

        void EndGCodeLineStream();

        event Action<ToolpathPreviewVertex[], int[], int> OnMeshGenerated;

        event Action<List<Vector3d>, int> OnLineGenerated;

        event Action<double, int> OnNewPlane;

        string Name { get; }
        Dictionary<int, VisualizerFillType> FillTypes { get; }

        IVisualizerCustomDataDetails CustomDataDetails0 { get; }
        IVisualizerCustomDataDetails CustomDataDetails1 { get; }
        IVisualizerCustomDataDetails CustomDataDetails2 { get; }
        IVisualizerCustomDataDetails CustomDataDetails3 { get; }
        IVisualizerCustomDataDetails CustomDataDetails4 { get; }
        IVisualizerCustomDataDetails CustomDataDetails5 { get; }
    }
}