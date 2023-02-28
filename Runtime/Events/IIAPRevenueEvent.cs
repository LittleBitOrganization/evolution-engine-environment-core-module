using System;

namespace LittleBitGames.Environment.Events
{
    public interface IIAPRevenueEvent
    {
        public event Action<IDataEventEcommerce> OnPurchasingProductSuccess;
    }
}