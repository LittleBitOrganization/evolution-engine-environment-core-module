namespace Events
{
    public class AdRevenueAnalytics
    {
        private readonly IAdsEventService _eventService;

        public AdRevenueAnalytics(IAdsEventService eventService, IMediationNetworkAnalytics analytics)
        {
            _eventService = eventService;

            analytics.OnAdRevenuePaidEvent += OnAdRevenuePaid;
        }

        private void OnAdRevenuePaid(IDataEventAdImpression data, AdType type)
        {
            if (type is AdType.Banner) return;

            _eventService.AdRevenuePaidEvent(data);
        }
    }
}