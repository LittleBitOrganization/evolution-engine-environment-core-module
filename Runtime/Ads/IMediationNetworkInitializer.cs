using System;

namespace Events
{
    public interface IMediationNetworkInitializer
    {
        event Action OnMediationInitialized;

        public void Initialize();
    }
}