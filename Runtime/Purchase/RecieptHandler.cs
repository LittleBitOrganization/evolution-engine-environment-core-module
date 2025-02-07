using System.Collections.Generic;
using UnityEditor;

namespace Purchase
{
    public class RecieptHandler
    {
        private Dictionary<string, object> _reciept;

        public Dictionary<string, object> Reciept => _reciept;

        private string _payload;
        private string _store;
        
        public RecieptHandler(Dictionary<string, object> reciept)
        {
            _reciept = reciept;
            
            _store = (string)_reciept["Store"];
            _payload = (string)_reciept["Payload"];
        }

        public GoogleRecieptData GetGoogleRecieptData()
        {
            var googleDetails = Json.Deserialize(_payload) as Dictionary<string, object>;
            var googleJson = (string)googleDetails["json"];
            var googleSig = (string)googleDetails["signature"];
            
            return new GoogleRecieptData(googleJson, googleSig);
        }

        public AppleRecieptData GetAppleRecieptData()
        {
            return new AppleRecieptData(_payload);
        }
        
        public AmazonRecieptData GetAmazonRecieptData()
        {
            var amazonDetails = Json.Deserialize(_payload) as Dictionary<string, object>;
            var amazonReceiptId = (string)amazonDetails["receiptId"];
            var amazonUserId = (string)amazonDetails["userId"];
            
            return new AmazonRecieptData(amazonReceiptId, amazonUserId);
        }
    }

    public struct AppleRecieptData
    {
        public string Payload { get; }

        public AppleRecieptData(string payload)
        {
            Payload = payload;
        }
    }
    
    public struct AmazonRecieptData
    {
        public string AmazonReceiptId { get; }
        public string AmazonUserId { get; }

        public AmazonRecieptData(string amazonReceiptId, string amazonUserId)
        {
            AmazonReceiptId = amazonReceiptId;
            AmazonUserId = amazonUserId;
        }
    }
    
    public struct GoogleRecieptData
    {
        public string Json { get; }
        public string Signature { get; }

        public GoogleRecieptData(string json, string signature)
        {
            Json = json;
            Signature = signature;
        }
    }
}