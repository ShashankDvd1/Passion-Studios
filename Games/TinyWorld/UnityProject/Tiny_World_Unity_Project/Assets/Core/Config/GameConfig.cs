using UnityEngine;

namespace WonderForge.TinyWorld.Core.Config
{
    /// <summary>
    /// The root ScriptableObject containing all tuning and configuration data for the game.
    /// Acts as the central hub for data injection to avoid Resources.Load.
    /// </summary>
    [CreateAssetMenu(fileName = "GameConfig", menuName = "Wonder Forge/Config/GameConfig", order = 0)]
    public class GameConfig : ScriptableObject
    {
        [Header("Global Settings")]
        [Tooltip("The version of the current configuration data.")]
        [SerializeField] private string configVersion = "1.0.0";

        // TODO: (Future Milestones) Add references to specific sub-configs here.
        // e.g., public PlayerConfig PlayerData => playerConfig;
        // [SerializeField] private PlayerConfig playerConfig;

        public string ConfigVersion => configVersion;
    }
}
