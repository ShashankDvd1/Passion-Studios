using WonderForge.TinyWorld.Core.Runtime.Interfaces;

namespace WonderForge.TinyWorld.Core.Config
{
    /// <summary>
    /// Contract for the configuration framework.
    /// Allows gameplay systems to read tuning data without referencing ScriptableObjects directly.
    /// </summary>
    public interface IConfigService : IGameService
    {
        /// <summary>
        /// Retrieves the root game configuration data.
        /// </summary>
        GameConfig GetRootConfig();
    }
}
