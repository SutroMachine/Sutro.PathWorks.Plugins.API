using Sutro.Core.Models.GCode;
using System.Collections.Generic;
using System.Linq;

namespace Sutro.PathWorks.Plugins.API.Generators
{
    public class GenerationOutput
    {
        public GenerationOutput(GCodeFile gcode, IEnumerable<string> materialUsage = null, IEnumerable<string> printTimeEstimate = null)
        {
            File = gcode;
            MaterialUsageEstimate = materialUsage.ToList().AsReadOnly();
            PrintTimeEstimate = printTimeEstimate.ToList().AsReadOnly();
        }

        public GCodeFile File { get; }

        public IReadOnlyList<string> MaterialUsageEstimate { get; }

        public IReadOnlyList<string> PrintTimeEstimate { get; }
    }
}