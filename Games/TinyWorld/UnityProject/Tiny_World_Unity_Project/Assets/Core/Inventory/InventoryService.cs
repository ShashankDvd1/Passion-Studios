using System;
using System.Threading.Tasks;
using WonderForge.TinyWorld.Core.Events;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;
using WonderForge.TinyWorld.Core.Save;
using WonderForge.TinyWorld.Core.Utilities;

namespace WonderForge.TinyWorld.Core.Inventory
{
    public class InventoryService : IInventoryService, IInitializable
    {
        private const string SAVE_KEY = "InventoryState";
        private const string LOG_PREFIX = "[Inventory]";

        private readonly ISaveService _saveService;
        private readonly IEventBus _eventBus;
        
        private InventoryData _data;

        public InventoryService(ISaveService saveService, IEventBus eventBus)
        {
            _saveService = saveService;
            _eventBus = eventBus;
            _data = new InventoryData();
        }

        public async Task InitializeAsync()
        {
            GameLogger.Log($"{LOG_PREFIX} Loading inventory data...");
            _data = await _saveService.LoadAsync<InventoryData>(SAVE_KEY);
            if (_data == null)
            {
                _data = new InventoryData();
            }
            GameLogger.Log($"{LOG_PREFIX} Inventory Service Initialized.");
        }

        public int GetResourceAmount(string resourceID)
        {
            return _data.GetResource(resourceID);
        }

        public bool HasEnough(string resourceID, int amount)
        {
            return GetResourceAmount(resourceID) >= amount;
        }

        public void AddResource(string resourceID, int amount)
        {
            if (amount <= 0) return;

            int current = GetResourceAmount(resourceID);
            int newAmount = current + amount;
            
            _data.SetResource(resourceID, newAmount);
            SaveAsync();

            _eventBus.Publish(new InventoryUpdatedEvent(resourceID, newAmount, amount));
            GameLogger.Log($"{LOG_PREFIX} Added {amount} {resourceID}. Total: {newAmount}");
        }

        public bool TryConsumeResource(string resourceID, int amount)
        {
            if (amount <= 0 || !HasEnough(resourceID, amount))
            {
                return false;
            }

            int current = GetResourceAmount(resourceID);
            int newAmount = current - amount;
            
            _data.SetResource(resourceID, newAmount);
            SaveAsync();

            _eventBus.Publish(new InventoryUpdatedEvent(resourceID, newAmount, -amount));
            GameLogger.Log($"{LOG_PREFIX} Consumed {amount} {resourceID}. Total: {newAmount}");
            return true;
        }

        private void SaveAsync()
        {
            // Fire and forget save to prevent blocking the main thread
            _ = _saveService.SaveAsync(SAVE_KEY, _data);
        }
    }
}
