using System.Threading.Tasks;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;
using WonderForge.TinyWorld.Core.Inventory;
using WonderForge.TinyWorld.Core.Events;
using WonderForge.TinyWorld.Core.Config;
using WonderForge.TinyWorld.Core.Utilities;

namespace WonderForge.TinyWorld.Core.Managers.Crafting
{
    public class CraftingService : ICraftingService, IInitializable
    {
        private readonly IInventoryService _inventoryService;
        private readonly IEventBus _eventBus;
        
        public CraftingService(IInventoryService inventoryService, IEventBus eventBus)
        {
            _inventoryService = inventoryService;
            _eventBus = eventBus;
        }

        public Task InitializeAsync()
        {
            GameLogger.Log("[CraftingService] Initialized.");
            return Task.CompletedTask;
        }

        public bool CanCraft(RecipeDefinition recipe)
        {
            if (recipe == null) return false;
            
            foreach (var cost in recipe.Costs)
            {
                if (!_inventoryService.HasEnough(cost.Resource.ResourceID, cost.Amount))
                {
                    return false;
                }
            }
            return true;
        }

        public bool TryCraft(RecipeDefinition recipe)
        {
            if (!CanCraft(recipe)) return false;

            // Deduct costs
            foreach (var cost in recipe.Costs)
            {
                _inventoryService.TryConsumeResource(cost.Resource.ResourceID, cost.Amount);
            }

            _eventBus.Publish(new CraftingCompletedEvent { Recipe = recipe });
            GameLogger.Log($"[CraftingService] Successfully crafted {recipe.DisplayName}!");
            
            return true;
        }
    }
}
