using Purchase;

namespace LittleBitGames.Environment.Events
{
    public interface IDataEventEcommerce
    {
        public string ItemId{ get; }

        public string CartType{ get; }

        public string Receipt { get; }

        public string Signature{ get; }

        public string Currency{ get; }

        public double Amount{ get; }

        public string ItemType{ get; }
        public string TransactionId{ get; }
        public  RecieptHandler ReceiptHandler{ get; }
    }
}