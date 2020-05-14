using g3;
using Sutro.Core.Models.GCode;
using System;
using System.Collections.Generic;
using System.IO;

namespace Sutro.PathWorks.Plugins.API
{
    public interface IGenerator
    {
        GCodeFile GenerateGCode(IList<Tuple<DMesh3, object>> parts,
                                object globalSettings,
                                out IEnumerable<string> generationReport,
                                Action<string> gcodeLineReadyF = null,
                                Action<string> progressMessageF = null);

        void SaveGCode(TextWriter output, GCodeFile file);

        GCodeFile LoadGCode(TextReader input);

        bool AcceptsParts { get; }
        bool AcceptsPartSettings { get; }

        Version Version { get; }
    }

    public interface IGenerator<TSettings> : IGenerator
    {
        GCodeFile GenerateGCode(IList<Tuple<DMesh3, TSettings>> parts,
                                TSettings globalSettings,
                                out IEnumerable<string> generationReport,
                                Action<string> gcodeLineReadyF = null,
                                Action<string> progressMessageF = null);
    }
}
