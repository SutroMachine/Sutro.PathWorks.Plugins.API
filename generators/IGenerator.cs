using g3;
using System;
using System.Collections.Generic;
using System.IO;

namespace Sutro.PathWorks.Plugins.API
{
    public interface IGenerator
    {
        IEnumerable<string> GenerateGCode(IList<Tuple<DMesh3, object>> parts,
                                object globalSettings,
                                out IEnumerable<string> generationReport,
                                Action<string> gcodeLineReadyF = null,
                                Action<string> progressMessageF = null);

        void SaveGCode(TextWriter output, IEnumerable<string> file);

        IEnumerable<string> LoadGCode(TextReader input);

        bool AcceptsParts { get; }
        bool AcceptsPartSettings { get; }

        Version Version { get; }
    }

    public interface IGenerator<TSettings> : IGenerator
    {
        IEnumerable<string> GenerateGCode(IList<Tuple<DMesh3, TSettings>> parts,
                                TSettings globalSettings,
                                out IEnumerable<string> generationReport,
                                Action<string> gcodeLineReadyF = null,
                                Action<string> progressMessageF = null);
    }
}
