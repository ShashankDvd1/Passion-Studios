using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;
using WonderForge.TinyWorld.Core.Utilities;

namespace WonderForge.TinyWorld.Core.Runtime
{
    /// <summary>
    /// The central orchestrator for all game services. 
    /// Manages the registration, initialization, ticking, and disposal of services.
    /// Does not use the Singleton pattern; must be instantiated and driven by an entry point (e.g., Bootstrapper or a persistent MonoBehaviour).
    /// </summary>
    public class GameRuntime : IDisposableService
    {
        private readonly List<IGameService> _services = new List<IGameService>();
        private readonly List<IInitializable> _initializables = new List<IInitializable>();
        private readonly List<IUpdatable> _updatables = new List<IUpdatable>();
        private readonly List<IDisposableService> _disposables = new List<IDisposableService>();

        private bool _isInitialized = false;

        /// <summary>
        /// Registers a service into the runtime. Segregates the service into appropriate lifecycle lists.
        /// </summary>
        /// <param name="service">The service instance to register.</param>
        public void RegisterService(IGameService service)
        {
            if (service == null)
            {
                GameLogger.LogError("Attempted to register a null service.");
                return;
            }

            _services.Add(service);

            if (service is IInitializable initializable)
            {
                _initializables.Add(initializable);
            }

            if (service is IUpdatable updatable)
            {
                _updatables.Add(updatable);
            }

            if (service is IDisposableService disposable)
            {
                _disposables.Add(disposable);
            }

            GameLogger.Log($"Registered Service: {service.GetType().Name}");
        }

        /// <summary>
        /// Asynchronously initializes all registered services that implement IInitializable.
        /// </summary>
        public async Task InitializeAllAsync()
        {
            if (_isInitialized)
            {
                GameLogger.LogWarning("GameRuntime is already initialized.");
                return;
            }

            GameLogger.Log("Starting Runtime Initialization...");

            foreach (var initializable in _initializables)
            {
                try
                {
                    await initializable.InitializeAsync();
                }
                catch (Exception ex)
                {
                    GameLogger.LogError($"Failed to initialize {initializable.GetType().Name}: {ex.Message}");
                    throw; // Rethrow to halt initialization if a critical service fails.
                }
            }

            _isInitialized = true;
            GameLogger.Log("Runtime Initialization Complete.");
        }

        /// <summary>
        /// Calls Tick on all registered services that implement IUpdatable.
        /// </summary>
        /// <param name="deltaTime">The time elapsed since the last frame.</param>
        public void Tick(float deltaTime)
        {
            if (!_isInitialized) return;

            // Iterate backwards or use a traditional for-loop if collection modification during Tick is expected.
            // Using a standard for-loop for maximum performance.
            for (int i = 0; i < _updatables.Count; i++)
            {
                _updatables[i].Tick(deltaTime);
            }
        }

        /// <summary>
        /// Disposes all registered services that implement IDisposableService and clears collections.
        /// </summary>
        public void Dispose()
        {
            GameLogger.Log("Disposing GameRuntime...");

            foreach (var disposable in _disposables)
            {
                try
                {
                    disposable.Dispose();
                }
                catch (Exception ex)
                {
                    GameLogger.LogError($"Error during disposal of {disposable.GetType().Name}: {ex.Message}");
                }
            }

            _services.Clear();
            _initializables.Clear();
            _updatables.Clear();
            _disposables.Clear();
            _isInitialized = false;

            GameLogger.Log("GameRuntime disposed successfully.");
        }
    }
}
