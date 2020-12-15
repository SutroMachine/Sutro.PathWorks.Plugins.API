using Sutro.Core.Models.GCode;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sutro.PathWorks.Plugins.API.Generators
{
    public abstract class GenerationResultBase
    {
    }

    public class GenerationResultFailure : GenerationResultBase
    {
        public GenerationResultFailure(string error)
        {
            Error = error;
        }

        public string Error { get; }
    }

    public class GenerationResultSuccess : GenerationResultBase
    {
        public GenerationResultSuccess(GCodeFile gcode, IGCodeInfo info)
        {
            GCodeFile = gcode;
            GCodeInfo = info;
        }

        public GCodeFile GCodeFile { get; }

        public IGCodeInfo GCodeInfo { get; }

    }
}