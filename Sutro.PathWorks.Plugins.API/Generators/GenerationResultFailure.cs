namespace Sutro.PathWorks.Plugins.API.Generators
{
    public class GenerationResultFailure : GenerationResultBase
    {
        public GenerationResultFailure(string error)
        {
            Error = error;
        }

        public string Error { get; }
    }
}