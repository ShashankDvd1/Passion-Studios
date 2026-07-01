using UnityEngine;

namespace WonderForge.TinyWorld.Core.Inventory
{
    [CreateAssetMenu(fileName = "NewResource", menuName = "TinyWorld/Resource Definition")]
    public class ResourceDefinition : ScriptableObject
    {
        [Header("Resource Metadata")]
        [Tooltip("The unique ID used to track this resource in the save file.")]
        public string ResourceID;
        
        [Tooltip("The display name shown in the UI.")]
        public string DisplayName;
        
        [Tooltip("The icon shown in the UI.")]
        public Sprite Icon;

        [Tooltip("The maximum amount of this resource the player can hold.")]
        public int MaxCapacity = 999;
    }
}
