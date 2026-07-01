using WonderForge.TinyWorld.Core.Runtime.Interfaces;

namespace WonderForge.TinyWorld.Core.Inventory
{
    public interface IInventoryService : IGameService
    {
        int GetResourceAmount(string resourceID);
        bool HasEnough(string resourceID, int amount);
        void AddResource(string resourceID, int amount);
        bool TryConsumeResource(string resourceID, int amount);
    }
}
