using WonderForge.TinyWorld.Core.Utilities;

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

            // Example of how future services will be registered:
            // var eventBus = new EventBus();
            // var saveManager = new SaveManager(eventBus);
            // runtime.RegisterService(eventBus);
            // runtime.RegisterService(saveManager);

            // TODO: (In Future Milestones) Instantiate and register concrete services here.
            // We ensure no concrete services are implemented in this milestone, as requested.

            GameLogger.Log("Service Installation Complete.");
        }
    }
}
