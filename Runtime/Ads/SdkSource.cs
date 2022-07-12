namespace Events
{
    public class SdkSource
    {
        public string Source { get; private set; }

        public SdkSource(string source)
        {
            Source = source;
        }
    }
}