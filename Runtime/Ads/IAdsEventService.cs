using LittleBitGames.Environment.Events;

namespace LittleBitGames.Environment.Ads
{
    public interface IAdsEventService
    {
        public void AdRevenuePaidEvent(IDataEventAdImpression data,
            EventsServiceType flags = EventsServiceType.Everything);
    }
}