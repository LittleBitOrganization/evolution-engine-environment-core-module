namespace Events
{
    public interface IAdsEventService
    {
        public void AdRevenuePaidEvent(IDataEventAdImpression data,
            EventsServiceType flags = EventsServiceType.Everything);
    }
}