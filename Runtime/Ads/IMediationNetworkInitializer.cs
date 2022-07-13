using System;

namespace LittleBitGames.Environment.Ads
{
    public interface IMediationNetworkInitializer
    {
        event Action OnMediationInitialized;

        public void Initialize();
    }
}