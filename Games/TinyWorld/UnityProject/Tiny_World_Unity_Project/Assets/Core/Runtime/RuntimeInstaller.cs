using WonderForge.TinyWorld.Core.Utilities;
using WonderForge.TinyWorld.Core.Events;

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
        public static void InstallServices(GameRuntime runtime)
        {
            GameLogger.Log("Starting Service Installation...");

            // Core Infrastructure
            var eventBus = new EventBus();
            
            // Registration
            runtime.RegisterService(eventBus);

            GameLogger.Log("Service Installation Complete.");
        }
    }
}
