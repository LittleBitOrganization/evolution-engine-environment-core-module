using LittleBitGames.Environment.Purchase;
using UnityEngine.Scripting;

namespace LittleBitGames.Environment.Events
{
    public class IapRevenueAnalytics
    {
        private readonly IIAPEventService _eventService;

        [Preserve]
        public IapRevenueAnalytics(IIAPEventService eventService, IIAPRevenueEvent revenueEvent)
        {
            _eventService = eventService;

            revenueEvent.OnPurchasingProductSuccess += OnPurchasingProduct;
        }

        private void OnPurchasingProduct(IDataEventEcommerce dataEvent)
        {
            _eventService.EcommercePurchase(dataEvent);
        }
    }
}