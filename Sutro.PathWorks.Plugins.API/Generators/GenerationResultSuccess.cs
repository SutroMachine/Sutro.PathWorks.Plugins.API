using Sutro.Core.Models.GCode;
using System.Collections.Generic;
using System.Linq;

namespace Sutro.PathWorks.Plugins.API.Generators
{
    public class GenerationResultSuccess : GenerationResultBase
    {
        public GenerationResultSuccess(GCodeFile gcode, IGCodeInfo info, IEnumerable<string> warnings = null)
        {
            File = gcode;
            Info = info;
            Warnings = warnings?.ToList() ?? new List<string>();
        }

        public GCodeFile File { get; }

        public IGCodeInfo Info { get; }

        public IReadOnlyList<string> Warnings { get; }
    }
}