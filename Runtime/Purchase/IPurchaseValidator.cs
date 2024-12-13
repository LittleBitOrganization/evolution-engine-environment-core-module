using System;
using System.Threading.Tasks;

namespace LittleBitGames.Environment.Purchase
{
    public interface IPurchaseValidator
    {
        public event Action<string> OnSuccessValidate;
        public event Action<string> OnFailureValidate;

        public Task<bool> ValidateAsync();

        public void Reset();
    }
}
