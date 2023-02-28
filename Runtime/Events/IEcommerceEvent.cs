namespace LittleBitGames.Environment.Events
{
    public interface IEcommerceEvent<in T> where T : IDataEventEcommerce
    {
        void EcommercePurchase(T data);
    }
}