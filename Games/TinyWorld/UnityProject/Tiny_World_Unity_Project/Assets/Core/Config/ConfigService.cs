using WonderForge.TinyWorld.Core.Runtime.Interfaces;
using WonderForge.TinyWorld.Core.Utilities;

namespace WonderForge.TinyWorld.Core.Config
{
    /// <summary>
    /// A lightweight wrapper around the GameConfig ScriptableObject.
    /// </summary>
    public class ConfigService : IConfigService, IInitializable
    {
        private readonly GameConfig _rootConfig;
        private const string LOG_PREFIX = "[Config]";

        public ConfigService(GameConfig rootConfig)
        {
            _rootConfig = rootConfig;
        }

        public System.Threading.Tasks.Task InitializeAsync()
        {
            if (_rootConfig == null)
            {
                GameLogger.LogError($"{LOG_PREFIX} GameConfig is null! Configuration injection failed.");
            }
            else
            {
                GameLogger.Log($"{LOG_PREFIX} Configuration loaded (Version: {_rootConfig.ConfigVersion}).");
            }

            return System.Threading.Tasks.Task.CompletedTask;
        }

        public GameConfig GetRootConfig()
        {
            return _rootConfig;
        }
    }
}
