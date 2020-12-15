using g3;
using Sutro.Core.Models.GCode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Sutro.PathWorks.Plugins.API.Generators
{
    public delegate bool WarningHandler(string warning);

    public interface IGenerator
    {
        GenerationResultBase GenerateGCode(
            IList<Tuple<DMesh3, object>> parts,
            object globalSettings,
            WarningHandler warningHandler = null,
            CancellationToken? cancellationToken = null);

        void SaveGCode(TextWriter output, GCodeFile file);

        GCodeFile LoadGCode(TextReader input);

        bool AcceptsParts { get; }
        bool AcceptsPartSettings { get; }

        Version Version { get; }
    }

    public interface IGenerator<TSettings> : IGenerator
    {
        GenerationResultBase GenerateGCode(
            IList<Tuple<DMesh3, TSettings>> parts,
            TSettings globalSettings,
            WarningHandler warningHandler = null,
            CancellationToken? cancellationToken = null);
    }
}