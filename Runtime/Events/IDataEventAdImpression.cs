using LittleBitGames.Environment.Ads;

namespace LittleBitGames.Environment.Events
{
    public interface IDataEventAdImpression
    {
        public SdkSource SdkSource { get; }
        public string AdSource { get; }

        public string AdFormat { get; }

        public string AdUnitName { get; }

        public string Currency { get; }

        public double Value { get; }
    }
}

