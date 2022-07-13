using System;
using LittleBitGames.Environment.Events;

namespace LittleBitGames.Environment.Ads
{
    public interface IMediationNetworkAnalytics
    {
        event Action<IDataEventAdImpression, AdType> OnAdRevenuePaidEvent;
    }
}