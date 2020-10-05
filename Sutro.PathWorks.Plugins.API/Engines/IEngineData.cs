namespace Sutro.PathWorks.Plugins.API.Engines
{
    public interface IEngineData
    {
        string Name { get; }
        string Version { get; }
        string Description { get; }
    }
}