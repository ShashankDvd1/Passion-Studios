using UnityEngine;
using WonderForge.TinyWorld.Core.Inventory;
using System.Collections.Generic;

namespace WonderForge.TinyWorld.Core.Config
{
    [System.Serializable]
    public struct ResourceCost
    {
        public ResourceDefinition Resource;
        public int Amount;
    }

    [CreateAssetMenu(fileName = "NewRecipe", menuName = "TinyWorld/Recipe Definition")]
    public class RecipeDefinition : ScriptableObject
    {
        [Header("Metadata")]
        public string RecipeID;
        public string DisplayName;
        public Sprite Icon;
        
        [Header("Economy Cost")]
        [Tooltip("The resources required to craft this item.")]
        public List<ResourceCost> Costs = new List<ResourceCost>();
        
        [Header("Rewards")]
        [Tooltip("If this item upgrades Spark's battery, how long can Spark explore now (in seconds)?")]
        public int UnlocksExpeditionDurationSeconds;
    }
}
