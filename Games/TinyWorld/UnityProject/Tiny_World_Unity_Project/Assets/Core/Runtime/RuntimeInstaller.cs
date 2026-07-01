using WonderForge.TinyWorld.Core.Utilities;
using WonderForge.TinyWorld.Core.Events;
using WonderForge.TinyWorld.Core.Save;
using WonderForge.TinyWorld.Core.Config;
using WonderForge.TinyWorld.Core.Managers.Audio;
using WonderForge.TinyWorld.Core.Managers.UI;
using WonderForge.TinyWorld.Core.Managers.Input;
using WonderForge.TinyWorld.Core.Inventory;

namespace WonderForge.TinyWorld.Core.Runtime
{
    /// <summary>
    /// Responsible for the manual construction and registration of all core services into the GameRuntime.
    /// Acts as the Composition Root for the runtime layer.
    /// </summary>
    public static class RuntimeInstaller
    {
        /// <summary>
        /// Creates and registers services into the provided GameRuntime instance.
        /// </summary>
        /// <param name="runtime">The GameRuntime orchestrator.</param>
        /// <param name="gameConfig">The root configuration object injected from the Bootstrapper.</param>
        public static void InstallServices(GameRuntime runtime, GameConfig gameConfig)
        {
            GameLogger.Log("Starting Service Installation...");

            // Core Infrastructure
            var eventBus = new EventBus();
            var saveService = new SaveService();
            var configService = new ConfigService(gameConfig);
            
            // Core Gameplay Systems
            var inventoryService = new InventoryService(saveService, eventBus);

            // Core Managers
            var audioService = new AudioService();
            var uiService = new UIService();
            var inputService = new InputService();
            
            // Registration - Infrastructure
            runtime.RegisterService(eventBus);
            runtime.RegisterService(saveService);
            runtime.RegisterService(configService);

            // Registration - Gameplay
            runtime.RegisterService(inventoryService);

            // Registration - Managers
            runtime.RegisterService(audioService);
            runtime.RegisterService(uiService);
            runtime.RegisterService(inputService);

            GameLogger.Log("Service Installation Complete.");
        }
    }
}
