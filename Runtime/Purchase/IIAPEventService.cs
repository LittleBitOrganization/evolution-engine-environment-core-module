using LittleBitGames.Environment.Events;

namespace LittleBitGames.Environment.Purchase
{
    public interface IIAPEventService
    {
        public void EcommercePurchase(IDataEventEcommerce dataEventEcommerce);
    }
}