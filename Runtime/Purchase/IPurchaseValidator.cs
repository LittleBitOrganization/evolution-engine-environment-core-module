using System;
using System.Threading.Tasks;
using UnityEditor.VersionControl;

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