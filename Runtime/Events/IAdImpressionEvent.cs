namespace Events
{
    public interface IAdImpressionEvent<in T> where T : IDataEventAdImpression
    {
        void AdRevenuePaidEvent(T data);
    }
}