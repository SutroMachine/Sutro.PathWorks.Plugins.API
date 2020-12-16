using System.Collections.Generic;

namespace Sutro.PathWorks.Plugins.API.Generators
{
    public interface IGCodeInfo
    {
        public IReadOnlyList<string> MaterialUsageEstimate { get; }

        public IReadOnlyList<string> PrintTimeEstimate { get; }
    }

}