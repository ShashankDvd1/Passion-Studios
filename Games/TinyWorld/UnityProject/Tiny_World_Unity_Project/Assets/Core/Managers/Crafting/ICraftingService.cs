using WonderForge.TinyWorld.Core.Runtime.Interfaces;
using WonderForge.TinyWorld.Core.Config;

namespace WonderForge.TinyWorld.Core.Managers.Crafting
{
    public interface ICraftingService : IGameService
    {
        bool CanCraft(RecipeDefinition recipe);
        bool TryCraft(RecipeDefinition recipe);
    }
}
