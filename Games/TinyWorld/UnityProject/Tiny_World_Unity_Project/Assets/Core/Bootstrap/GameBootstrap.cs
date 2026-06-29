using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using WonderForge.TinyWorld.Core.Runtime;
using WonderForge.TinyWorld.Core.Utilities;

namespace WonderForge.TinyWorld.Core.Bootstrap
{
    /// <summary>
    /// The primary entry point for the application. 
    /// Resides in the initial Bootstrap scene and handles the sequential initialization of all core systems.
    /// </summary>
    public class GameBootstrap : MonoBehaviour
    {
        [Header("Scene Configuration")]
        [Tooltip("The name of the next scene to load after initialization completes.")]
        [SerializeField] private string nextSceneName = "MainMenu";

        // In a more advanced setup, this could be populated via a DI container or serialized references.
        private readonly List<ICoreSystem> _coreSystems = new List<ICoreSystem>();

        private async void Start()
        {
            DontDestroyOnLoad(gameObject);
            GameLogger.Log("GameBootstrap started. Beginning initialization sequence...");

            try
            {
                await InitializeSystemsAsync();
                LoadNextScene();
            }
            catch (Exception ex)
            {
                GameLogger.LogError($"Initialization failed: {ex.Message}\n{ex.StackTrace}");
                // Handle critical failure (e.g., show an error UI to the user)
            }
        }

        /// <summary>
        /// Sequentially initializes all registered core systems.
        /// </summary>
        private async Task InitializeSystemsAsync()
        {
            // Note: In upcoming milestones, systems like EventBus, SaveSystem, and ConfigSystem 
            // will be instantiated and added to _coreSystems here.

            foreach (var system in _coreSystems)
            {
                var systemName = system.GetType().Name;
                GameLogger.Log($"Initializing {systemName}...");
                
                await system.InitializeAsync();
                
                GameLogger.Log($"{systemName} initialized successfully.");
            }

            GameLogger.Log("All core systems initialized.");
        }

        /// <summary>
        /// Loads the next scene once initialization is complete.
        /// </summary>
        private void LoadNextScene()
        {
            if (string.IsNullOrEmpty(nextSceneName))
            {
                GameLogger.LogWarning("Next scene name is empty. Staying in Bootstrap scene.");
                return;
            }

            GameLogger.Log($"Loading next scene: {nextSceneName}");
            SceneManager.LoadSceneAsync(nextSceneName);
        }
    }
}
