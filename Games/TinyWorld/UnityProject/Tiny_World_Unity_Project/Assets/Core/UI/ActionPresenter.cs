using UnityEngine;
using WonderForge.TinyWorld.Core.Runtime;
using WonderForge.TinyWorld.Core.Managers.Expedition;
using WonderForge.TinyWorld.Core.Managers.Crafting;
using WonderForge.TinyWorld.Core.Config;
using WonderForge.TinyWorld.Core.Utilities;

namespace WonderForge.TinyWorld.UI
{
    /// <summary>
    /// Attach this script to a GameObject in your Canvas. 
    /// You can then point Unity Buttons to the OnClick methods here.
    /// </summary>
    public class ActionPresenter : MonoBehaviour
    {
        [Header("Recipe References")]
        [Tooltip("Drag your RecipeDefinition assets here so the buttons know what to craft.")]
        public RecipeDefinition SignalBoosterRecipe;
        public RecipeDefinition LanternRecipe;
        public RecipeDefinition BatteryRecipe;

        /// <summary>
        /// Sends Spark on an expedition.
        /// </summary>
        public void OnClickStartExpedition(int durationSeconds)
        {
            if (GameRuntime.Instance != null && GameRuntime.Instance.TryGetService<IExpeditionService>(out var expeditionService))
            {
                if (!expeditionService.IsExploring())
                {
                    expeditionService.StartExpedition(durationSeconds);
                }
                else
                {
                    GameLogger.LogWarning("Spark is already exploring!");
                }
            }
        }

        // Helper methods for Unity UI OnClick events (Unity Buttons can't easily pass integers)
        public void OnClickStartExpedition10Min() => OnClickStartExpedition(600);
        public void OnClickStartExpedition1Hour() => OnClickStartExpedition(3600);
        public void OnClickStartExpedition4Hours() => OnClickStartExpedition(14400);

        private void CraftItem(RecipeDefinition recipe)
        {
            if (recipe == null)
            {
                GameLogger.LogError("Recipe is missing! Please assign it in the Inspector of the ActionPresenter.");
                return;
            }

            if (GameRuntime.Instance != null && GameRuntime.Instance.TryGetService<ICraftingService>(out var craftingService))
            {
                if (!craftingService.TryCraft(recipe))
                {
                    GameLogger.LogWarning($"Not enough resources to craft {recipe.DisplayName}!");
                }
            }
        }

        public void OnClickCraftSignalBooster() => CraftItem(SignalBoosterRecipe);
        public void OnClickCraftLantern() => CraftItem(LanternRecipe);
        public void OnClickCraftBattery() => CraftItem(BatteryRecipe);
    }
}
