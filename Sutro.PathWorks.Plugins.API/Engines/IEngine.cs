﻿using Sutro.Core.Models.Profiles;
using Sutro.PathWorks.Plugins.API.Settings;
using Sutro.PathWorks.Plugins.API.Visualizers;
using System.Collections.Generic;

namespace Sutro.PathWorks.Plugins.API.Engines
{
    public interface IEngine
    {
        string Name { get; } 
        string Description { get; }

        IGenerator Generator { get; }
        ISettingsManager SettingsManager { get; }
        List<IVisualizer> Visualizers { get; }

        List<string> FileExtensions { get; }
    }

    public interface IEngine<TSettings> : IEngine where TSettings : IProfile
    {
        new IGenerator<TSettings> Generator { get; }
        new ISettingsManager<TSettings> SettingsManager { get; }
    }
}