namespace Sutro.PathWorks.Plugins.API.Visualizers
{
    public class VisualizerCustomDataDetailsCollection
    {
        public IVisualizerCustomDataDetails Field0 { get; }
        public IVisualizerCustomDataDetails Field1 { get; }
        public IVisualizerCustomDataDetails Field2 { get; }
        public IVisualizerCustomDataDetails Field3 { get; }
        public IVisualizerCustomDataDetails Field4 { get; }
        public IVisualizerCustomDataDetails Field5 { get; }

        public VisualizerCustomDataDetailsCollection(
            IVisualizerCustomDataDetails field0 = null,
            IVisualizerCustomDataDetails field1 = null,
            IVisualizerCustomDataDetails field2 = null,
            IVisualizerCustomDataDetails field3 = null,
            IVisualizerCustomDataDetails field4 = null,
            IVisualizerCustomDataDetails field5 = null)
        {
            Field0 = field0;
            Field1 = field1;
            Field2 = field2;
            Field3 = field3;
            Field4 = field4;
            Field5 = field5;
        }
    }
}