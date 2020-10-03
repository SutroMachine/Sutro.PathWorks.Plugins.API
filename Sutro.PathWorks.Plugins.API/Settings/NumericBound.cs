namespace Sutro.PathWorks.Plugins.API.Settings
{
    public class NumericBound<T>
    {
        public T Value { get; set; }
        
        public bool Inclusive { get; set; }

        public NumericBound(T value, bool inclusive)
        {
            Value = value;
            Inclusive = inclusive;
        }
    }
}
