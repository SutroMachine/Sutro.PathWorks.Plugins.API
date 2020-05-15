﻿namespace Sutro.PathWorks.Plugins.API.Visualizers
{
    public readonly struct CustomColorData
    {
        public double? Field0 { get; }
        public double? Field1 { get; }
        public double? Field2 { get; }
        public double? Field3 { get; }
        public double? Field4 { get; }
        public double? Field5 { get; }

        public CustomColorData(
            double? field0 = null, double? field1 = null, double? field2 = null, 
            double? field3 = null, double? field4 = null, double? field5 = null)
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