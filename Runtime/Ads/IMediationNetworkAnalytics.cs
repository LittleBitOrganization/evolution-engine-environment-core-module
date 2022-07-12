using System;

namespace Events
{
    public interface IMediationNetworkAnalytics
    {
        event Action<IDataEventAdImpression, AdType> OnAdRevenuePaidEvent;
    }
}