using System;

namespace LittleBitGames.Environment.Ads
{
    public interface IMediationNetworkInitializer
    {
        event Action OnMediationInitialized;

        public bool IsInitialized { get; }
        
        public void Initialize();
    }
}